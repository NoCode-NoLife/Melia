Web Server
=============================================================================

For ease of use, Melia comes with its own, simple web server, because the
game client requires certain files to be served to it via HTTP on lauch.
With this, Melia is practically plug-and-play, though you are free to
use your own web server. In fact, for actual production usage, we would
very much recommend a mature and widely used server, such as Apache or
NGINX, but our web server is perfectly capable of doing the job in less
demanding scenarios.


Operation
-----------------------------------------------------------------------------

The web server is started together with the other servers and runs on
port 80 by default, which means that you can access it by navigating
your browser to http://127.0.0.1 if you're running it on your computer.
If everything is working as expected, you should see a page saying
something along the lines of "Melia Web Server".

However, it's possible other applications are already using port 80,
in which case the web server will display an error and you won't be
seeing the aforementioned website when navigating there. In this case,
you have to either close the other application, reconfigure it to use
a different port, or change the port Melia's web server is running on.
This can be accomplished in the file `conf/web.conf`.

If you change the port of the web server, you have to append the custom
port to the URL to access its resources. For example, if you changed the
port from 80 to 8080, you'd use http://127.0.0.1:8080.


Client Launch
-----------------------------------------------------------------------------

The two primary resources the web server serves clients are the files
`serverlist.xml` and `static__Config.txt`, which are generated internally
and can't be found directly in Melia's file structure. They are vital in
telling the client where to connect to and how, to be able to log into
your Melia server. By default, these files can be viewed under the following
addresses.

- http://127.0.0.1/toslive/patch/serverlist.xml
- http://127.0.0.1/toslive/patch/static__Config.txt

You might recognize this URL structure from the client's `client.xml`,
where the URLs to these files are configured. Make sure that they reflect
the URLs the files can be accessed at on your web server. For example:

```xml
<GameOption ServerListURL="http://127.0.0.1/toslive/patch/serverlist.xml" StaticConfigURL="http://127.0.0.1/toslive/patch/"
```

Note that for other people to connect to your server, especially from
outside your network, you need to use a public address and make the
web server accessible through it.


Custom Content
-----------------------------------------------------------------------------

While the web server is primarily intended for serving the necessary files
for launching the client, it is also capable of serving downloads or web
pages. For static content, such as HTML, CSS, and JS files, you would
simply place them in your `user/web/` folder, after which they will be
accessible through your browser.

File
```text
|- system
|- user
   |- web
      |- mypage.htm
```

URL
```text
http://127.0.0.1/mypage.htm
```

You can also utilize the server's API to retrieve information about the
server or execute certain functions, such as sending broadcast messages.
See the web API documentation for more information.


Dynamic Custom Content
-----------------------------------------------------------------------------

Aside from static content, the web server also supports scripting via CGI
for server-side content generation and code execution, with the primary
language of choice for us being PHP. While no longer the trendiest of
options, we decided to go this route for maximum portability and ease
of use, as you will be able to move all scripts made for our web server
to any other server that supports PHP, and vice-versa.

### PHP Setup

All that is needed for PHP to be used is for it to be installed and
configured, which the web server does automatically if it's running
on Windows. It downloads a copy of the latest version from the official
website and moves it to the `user/tools/php/` folder, which is the
default location configured in the `web.conf`. To update or reinstall
PHP, simply remove the folder and let the web server redownload it
on launch.

For other operating systems, such as Linux, you need to install PHP
yourself, although it often comes pre-installed--especially on web-
oriented hosting providers. You then only need to adjust the option
`cgi_processor_php` in `web.conf` to point the CGI processor towards
your installation.

For example:
```text
cgi_processor_php: PHP; .php; /usr/bin/php
```

You can also specify your own PHP installation on Windows if so
desired.

### PHP Usage

As with static content, PHP files are simply placed into the web
folder and can then be accessed via a browser. The server recognizes
the PHP file extension and executes them using the configured PHP
installation. For security reasons, files with the `.php` extension
are not served at all if no PHP interpreter could be found.

It's our goal for the PHP support to be on-par with other web servers,
so that any script will run anywhere, regardless of the environment.
Should you encounter any problems, such as our web server not running
a script correctly, please report the issue.

### Other Languages

In addition to PHP, you can use most other scripting languages with
our web server as well. Simply add a CGI processor for your language
of choice, specifying the file extensions it should handle and the
path to the executable.

For example, if you wanted to write web pages in Python, that line
might look something like this:
```text
cgi_processor_python: Python; .py; C:/Python/python.exe
```

If you then open a URL such as `http://127.0.0.1/test.py`, the server
will launch `python.exe` with the path to the `test.py` file as the
first argument, and whatever that script outputs goes directly to
the browser. 

For more information about CGI and how it might liven up your existence,
please refer to the riveting world of technical specifications.

https://datatracker.ietf.org/doc/html/rfc3875
