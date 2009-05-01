<?php
	$auth_db_link = mysql_connect($config['database']['server'], $config['database']['username'], $config['database']['password'])
		or trigger_error("MySQL error: " . mysql_error());
	mysql_select_db($config['database']['db'])
		or trigger_error("MySQL error: " . mysql_error());
?>