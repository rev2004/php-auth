CREATE TABLE `auth_users`
(
	`username` varchar(45) NOT NULL,
	`password` varchar(255) NOT NULL,
	`oath_key` blob,
	`cookie` varchar(255) default NULL,
	PRIMARY KEY  (`username`),
	UNIQUE KEY `Index_Cookie` (`cookie`)
) COMMENT='User Authentication Table';

CREATE TABLE `auth_log`
(
	`event_id` int(10) unsigned NOT NULL auto_increment,
	`event_time` datetime NOT NULL,
	`event` varchar(255) NOT NULL,
	`url` varchar(255) default NULL,
	`username` varchar(45) NOT NULL,
	`ip_address` varchar(15) NOT NULL,
	PRIMARY KEY  (`event_id`),
) COMMENT='Authentication Log';