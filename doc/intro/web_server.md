Web Server
=============================================================================

Since a web server is basically required to connect to any other servers
than the official ones, Melia comes with its own, simple web server.

The web server is started together with the other servers and runs on
port 80 by default, which means that you can access it by navigating
your browser to http://127.0.0.1, if you're running it on your computer.
However, it's possible other applications are already using port 80.
If that's the case, you have to either close them, reconfigure them,
or you have to change the port Melia's web server is running on in
the configuration, at `system/conf/web.conf`. Otherwise you will get
an error on start up.

If you change the port of the web server, you have to append it to
the address. For example, instead of http://127.0.0.1, you have to
use http://127.0.0.1:8080, if you changed the port to 8080.
