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