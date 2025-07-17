Getting Started
=============================================================================

Setup (Windows)
-----------------------------------------------------------------------------

### Requirements

* MySQL compatible database server,  
  e.g. [MySQL Server Community Edition](http://dev.mysql.com/downloads/mysql/)
  or [MariaDB](http://mariadb.org/)
* A MySQL management software,  
  e.g. [HeidiSQL](http://www.heidisql.com/)
* [Microsoft Visual Studio 2019+](https://visualstudio.microsoft.com/vs/community/)
* [Git](http://git-scm.com/downloads) (optional)

### Obtaining the source code

The easiest way to download the source code is to head over to
[GitHub](https://github.com/aura-project/melia) and click the "Download
ZIP" button on the repository's page.

Alternatively you can use git, a command line tool for managing Git
repositories. The advantage is that updating is a little easier, because
you don't have to re-download the Zip file, merge the new and the old
files, etc.

To download the source code with git, install it, open the Command
Prompt (Windows key + R, type "cmd" and press "OK"), navigate to the
directory you want to download Melia to by using the "cd" command
(change directory) and in there type:
```
git clone https://github.com/NoCode-NoLife/melia.git
```
This will download a copy of the repository into the current folder,
into a sub-folder called "melia".

To update it you do the same, but go into the "melia" folder and enter
```
git pull
```
instead. This will "pull" the latest changes from the online repository.

### Setting up the database

Once you've obtained a copy of the Melia source code, you must set up
your database. Download MySQL or MariaDB and follow the instructions
during the setup. Afterwards, open `<melia directory>/sql/main.sql` in
your query browser (e.g. HeideSQL) *and run it*, to create the basic
structure for Melia.

Then, navigate to `user/conf/` and create a file called database.conf.
Put the following into the file, with your username and password:
```
user : <MySQL Username>
pass : <MySQL Password>
```
Save and close database.conf.

### Compiling

Open the file Melia.sln in the melia folder in Visual Studio. Under the
Build Menu, select Build or simply hit F6. Melia should compile
automatically, you don't need to do anything else with the source code.

Once you have finished compiling, simply launch start-all.bat and your
server should be running.

## Connecting to a Melia Server

To connect to a server other than the official one, you need to modify
the client's "client.xml" file, specifically, the values "ServerListURL"
and "StaticConfigURL". Make a backup of the original file if you want to
be able to still connect to officials.

Change "ServerListURL" to point to the server list XML, and
"StaticConfigURL" to the folder that contains the static_Config.txt. For
example, if you're running Melia's web server on port 8080 your settings
might look like this:

```xml
<GameOption ServerListURL="http://127.0.0.1:8080/toslive/patch/serverlist.xml" StaticConfigURL="http://127.0.0.1:8080/toslive/patch/"
```

Once you have modified your client.xml, you can start the client.

Note: To start the client directly from the TOS directory, you have to
start it with the parameter `-SERVICE`.

## Creating an account

To create a new account, type "new//account_name" at the login window.
(Replace "account_name" with your desired name.) The server will create
that new account, with the password you've used. After the first login
you don't need the "new//" prefix anymore.

## Becoming a GM

There are various [[GM Commands]] that can be used by GMs. To use them,
an account needs specific minimum authority levels. You can change an
account's authority directly in the database or by using the command
"auth" in the login server's window.
