CREATE TABLE `auth_users`
(
	`username` varchar(45) NOT NULL,
	`password` varchar(255) NOT NULL,
	`open_id` varchar(255) default NULL,
	`oath_key` varchar(1024) default NULL,
	`session_id` varchar(355) default NULL,
	`cookie` varchar(255) default NULL,
	PRIMARY KEY  (`username`),
	KEY `open_id` (`open_id`),
	KEY `session_id` (`session_id`),
	KEY `cookie` (`cookie`)
)

CREATE TABLE `auth_log`
(
	`event_time` datetime NOT NULL,
	`event` varchar(255) NOT NULL,
	`username` varchar(45) NOT NULL,
	`ip_address` varchar(15) NOT NULL,
	PRIMARY KEY  (`event_time`)
) 