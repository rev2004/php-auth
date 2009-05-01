<?php
function GenerateOtp($secret,$movingFactor, $codeDigits = 6, $addChecksum = false,$truncationOffset = -1)
{
	$data = pack ('C*', $movingFactor);
	$data = str_pad($data,8,chr(0),STR_PAD_LEFT);
	$hash = hash_hmac('sha1',$data,$secret);

		// Convert to dec
	foreach(str_split($hash,2) as $hex)
	{
		$hmac_result[]=hexdec($hex);
	}

	// Find offset
	if($truncationOffset == -1)
	{
		$offset = $hmac_result[19] & 0xf;
	}
	else
	{
		$offset = $truncationOffset;
		}

	// Algorithm from RFC
	return
	(
		(($hmac_result[$offset+0] & 0x7f) << 24 ) |
		(($hmac_result[$offset+1] & 0xff) << 16 ) |
		(($hmac_result[$offset+2] & 0xff) << 8 ) |
		($hmac_result[$offset+3] & 0xff)
	) % pow(10,$codeDigits);
}
GenerateOtp("12345678901234567890",$i,6,false,0). "\n";

?>