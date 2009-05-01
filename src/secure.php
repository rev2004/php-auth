<?php
	session_start();
	$config = parse_ini_file("auth.ini",true);
	require_once "auth_database.php";
	
	$auth_sql = "SELECT * FROM `{$config['tables']['users']}` WHERE `cookie` = '" . session_id() . "'";
	$result = mysql_query($auth_sql);

	if(mysql_num_rows($result)==0)
	{
		header("Location: {$config['auth']['base_dir']}/login.php?url={$_SERVER['SCRIPT_URI']}");
		exit;
	}
	else
	{
		if($config['log']['access'] == 'true')
		{
			$log_sql = "INSERT INTO `{$config['tables']['log']}` (`event_time`,`event`,`url`,`username`,`ip_address`) VALUES(NOW(),'access','{$_SERVER['SCRIPT_URI']}','{$_SESSION['user']['username']}','{$_SERVER['REMOTE_ADDR']}')";
			mysql_query($log_sql)
				or trigger_error(mysql_error());
		}
	}
?>