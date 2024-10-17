Melia
=============================================================================

Melia is an open-source MMORPG server, developed as a collaborative effort
of programmers from all around the world. We're aiming to create a server
software that provides a stable and extensible platform for users to build
their own projects on top of, while giving developers the oppurtunity to
learn and hone their skills in a familar environment.

This project is very explicilty not about playing a game or competing
with any services provided by game developers or publishers, and we don't
endorse such actions. We're here to learn and create, not to steal or
destroy.

State of Development
-----------------------------------------------------------------------------

Melia has been in semi-active development for several years, and is
being worked on more or less depending on the time and motivation of
the available developers. The server is functional and provides many
of the typical features you would expect from an online RPG, but
there's still a way to go before we'd call it truly playable.

Specifically, some of the major features that are working are as follows:

- Characters (creation, deletion, etc.)
- Inventory (managing items, equipping, etc.)
- Chat
- Stats
- Skills
  - Distrbution of skill points
  - Basic and experimental combat, incl. monster AI
  - Basic and experimental support for select skills
- NPC dialogues and shops
- Monster spawns
- Quests

Installation with Docker
-----------------------------------------------------------------------------

This branch aims to make Melia easier to setup and run in any environment.
To achieve this, we're making a few changes do add the capability of building
and running Melia on Linux, as well as building and running the server in a
few Docker containers.

For this to work, you will need [Docker](https://docs.docker.com/) installed
on your system. Recent versions of Docker comes with [Docker Compose](https://docs.docker.com/compose/)
pre-installed, so you don't have to worry about it.

After cloning or downloading this repository, rename file `.env.example` to
`.env` and change configuration as needed. Then, navigate to the project folder
(where you'll find `docker-compose.yml` ) and run:

```bash
docker compose build
```

This will download the necessary Docker Images for our project to run and
build a new image with `./Servers/Dockerfile`, where our server dependencies
are listed.

Now, you can run:

```bash
docker compose run --rm melia-server dotnet build
```

This will create our server binaries, making it ready to start with our next
command:

```bash
docker compose up -d
```

Wait for a few seconds for everything to initialize. Then, you can go to your
browser and access [http://127.0.0.1/toslive/patch/serverlist.xml] to check
if server is up and running.

You can restart server if anything goes wrong using:

```bash
docker compose restart
```

If you change anything on source code, you need to run
`docker compose run --rm melia-server dotnet build` again and restart your
server with `docker compose restart`

Database with Docker
-----------------------------------------------------------------------------

With the Docker containers, we've added a PHPMyAdmin container, which can be
accessed via [http://127.0.0.1:8080]. Default user is `root` and password
is `123456` (You can change password on `.env`, but remember to change on
`user/conf/database.conf` as well).

Client
-----------------------------------------------------------------------------

Melia does not have a client of its own at this time. Instead, it's designed
to be network compatible with the latest client of the international
version of ToS, which is freely available on Steam.

After downloading, open your client folder (Steam > Right-Click on Game >
Manage > Browse Local Files). Then, open `release/client.xml` with a text
editor.

Change the line which starts with `<GameOption ServerList [...]` to this:

```xml
<GameOption ServerListURL="http://127.0.0.1/toslive/patch/serverlist.xml" StaticConfigURL="http://127.0.0.1/toslive/patch/" NewAccountURL="http://127.0.0.1/" PaymentURL="http://127.0.0.1/" LoadingImgURL="http://127.0.0.1/toslive/patch/loadingimg/" LoadingImgCount="10"/>
```

Note: If your server is not on the same machine you're playing, change
`127.0.0.1` to your Server's LAN / WAN IP.

Now you can open your game and play.

If you're using Docker, you can't use server's console to create your
account, so, when logging in for the first time, use `new__` as a prefix
to your username.

Example:

```bash
Username: new__myaccount
Password: mypassword
```

This will create an account with username `myaccount` and password
`mypassword`. You can check the database to make sure everything is okay,
but you'll already be connected and playing. Next time, just login with
your username without the `new__` prefix.

Installation from scratch
-----------------------------------------------------------------------------

- Compile Melia
- Run `sql/main.sql` to setup the database
- Copy `system/conf/database.conf` to `user/conf/`,
  adjust the necessary values and remove the rest.

Afterwards, you should be able to start Melia via the provided scripts or
directly from the bin directories. If not, or if you need a more detailed
guide, head over to our forum, the chat, or the wiki.

Requirements to build from scratch
-----------------------------------------------------------------------------

Melia is being developed in C# (.NET 8+) and uses a MySQL database for
its storage. As such, to use Melia you will need the following:

- The .NET SDK (8+)
- A MySQL-compatible database server (MariaDB 10+ recommended)

On an up-to-date Windows system, the SDK will already be included,
so you only need to install a MySQL-compatible server. On Linux and
macOS, you will need to install the SDK as well.

For more detailed instructions, please wait patiently while we give
our documentation a much-needed overhaul. It's only a matter of time.

Contribution
-----------------------------------------------------------------------------

Check the file CONTRIBUTING.md for instructions on how you may contribute.

Links
-----------------------------------------------------------------------------

- GitHub: https://github.com/NoCode-NoLife/melia
- Wiki: https://github.com/NoCode-NoLife/melia/wiki
- Forum: https://nocodenolife.org/forum/65-melia/
- Chat: https://discord.gg/5sszEgw
