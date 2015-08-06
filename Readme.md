# Description #
This is a simple PHP system for securely authenticating users against a MySQL database.

# Features #
  * Passwords stored as md5 hashes
  * Client sends hashed passwords
    * When login script is accessed, it generates a challenge that is stored in a session variable and sent to the client.  When the client submits the form, the script uses this challenge value to compute a one way hash of the password's md5 hash, and blanks the password field to prevent it from being sent.  The challenge is not sent back to the server.
    * The server script computes the the same hash from the md5 hash in the database and the challenge value stored in the session variable.
  * OATH compliant HOTP tokens
  * Stylesheet
    * Login form utilizes CSS id and class tags to be fully customizable
  * Ability to be included in other pages
    * The login form can be utilized stand-alone, or included in another page with zero modification.
  * Configurable logging of events:
    * Successful logins
    * Failed logins,
    * Logouts
    * Page accesses.

# Use #
  1. Copy the files into a directory on the web server.
  1. Edit the '[auth.ini](Configuration.md)' file to set the proper values for the database and the script's location, as well as the options for logging.
  1. Import the 'auth\_db.sql' file into the database.
  1. dd your users with your favorite database management utility.  Make sure that the passwords in the database are stored as md5 hashes! (a web-based javascript md5 hashing utility is included).
  1. On any page that you wish to secure, include the 'secure.php' file with the require statement:
```
require "auth_dir/secure.php";
```

where auth\_dir is the directory that the script was installed.