@echo off
rem Server start up script
rem -------------------------------------------------------------------------
rem Tries to start the server passed as first argument from bin\ or its
rem sub-folders (Release and Debug). If no argument is passed it calls all
rem start bats, to start all servers.
rem -------------------------------------------------------------------------

if "%1" == "" goto NO_ARGS

set FILENAME=%1
set GROUP_ID=%2
set SERVER_ID=%3

rem Check for a build in bin\ first
if not exist bin\%FILENAME%.exe goto SUB_RELEASE
set PATH=bin\
goto RUN

rem Huh, maybe there's a build in bin\Release?
:SUB_RELEASE
IF NOT EXIST bin\Release\%FILENAME%.exe GOTO SUB_DEBUG
set PATH=bin\Release\
goto RUN

rem Mah... come here debug!
:SUB_DEBUG
IF NOT EXIST bin\Debug\%FILENAME%.exe GOTO ERROR
set PATH=bin\Debug\

rem Go, go, go!
:RUN
echo Running %FILENAME% from %PATH%
%windir%\system32\ping -n 2 127.0.0.1 > nul
cls
cd %PATH%
%FILENAME%.exe %GROUP_ID% %SERVER_ID%
exit

rem Now I'm a saaad panda qq
:ERROR
echo Couldn't find %FILENAME%.exe
pause

exit

:NO_ARGS
start start-barracks
start start-zone-1
start start-zone-2
start start-social
start start-web
