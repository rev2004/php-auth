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
		if($config['log']['logout'] == 'true')
		{
			$log_sql = "INSERT INTO `{$config['tables']['log']}` (`event_time`,`event`,`username`,`ip_address`) VALUES(NOW(),'logout','{$_SESSION['user']['username']}','{$_SERVER['REMOTE_ADDR']}')";
			mysql_query($log_sql)
				or trigger_error(mysql_error());
		}
		$logout_sql = "UPDATE `{$config['tables']['users']}` SET `cookie` = NULL WHERE `cookie` = '" . session_id() . "'";
		mysql_query($logout_sql)
			or trigger_error(mysql_error());
		
		session_destroy();
		echo "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n";
		echo "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Strict//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd\">\n";
		echo "<html xmlns=\"http://www.w3.org/1999/xhtml\" xml:lang=\"en\">\n";
		echo "\t<head>\n";
		echo "\t\t<title>Logged out</title>\n";
		echo "\t\t<link rel=\"stylesheet\" type=\"text/css\" href=\"auth.css\"></link>\n";
		echo "\t</head>\n";
		echo "\t<body>\n";
		echo "\t\t<p>You have been logged out. <a href=\"{$_SERVER['HTTP_REFERER']}\">Return</a></p>\n";
		echo "\t</body>\n";
		echo "</html>";

	}
?>