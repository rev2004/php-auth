The `auth.ini` file is very simple.  It is divided into four sections, and generally looks like this:
```
[auth]
base_dir = "/auth"

[database]
server = ""
db = ""
username = ""
password = ""

[tables]
users = "auth_users"
log = "auth_log"

[log]
login = "true"
logout = "true"
access = "true"
failed = "true"

[options]
use_oath = "false"
```

# `auth` #
  * `base_dir`:  Defines the base directory for the `php-auth` scripts from the web root.

# `database` #
  * `server`: The hostname of the database server.
  * `db`: The name of the database.
  * `username`: The username to connect to the database.
  * `password`: The password for connecting to the database.

# `tables` #
  * `users`: The table that user information is stored.  Only needs to be changed if the default `auth_users` was changed.
  * `log`: The table that authentication logs are stored.  Only needs to be changed if the default `auth_log` was changed.

# `log` #
  * `login`: Set `"true"` to log all successful logins.
  * `logout`: Set `"true"` to log all logouts.
  * `access`: Set `"true"` to log all successful page accesses.
  * `failed`: Set `"true"` to log all failed logins.

# `options` #
  * `use_oath`: Set `"true"` to use OATH HOTP tokens instead of passwords.