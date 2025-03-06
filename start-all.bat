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
set SUBFOLDER=net8.0

rem Check for a build in bin\ first
if not exist bin\%SUBFOLDER%\%FILENAME%.exe goto SUB_RELEASE
set PATH=bin\%SUBFOLDER%\
goto RUN

rem Huh, maybe there's a build in bin\Release?
:SUB_RELEASE
IF NOT EXIST bin\Release\%SUBFOLDER%\%FILENAME%.exe GOTO SUB_DEBUG
set PATH=bin\Release\%SUBFOLDER%\
goto RUN

rem Mah... come here debug!
:SUB_DEBUG
IF NOT EXIST bin\Debug\%SUBFOLDER%\%FILENAME%.exe GOTO ERROR
set PATH=bin\Debug\%SUBFOLDER%\
goto RUN

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
start "" cmd /c start-barracks
start "" cmd /c start-zone-1
start "" cmd /c start-zone-2
start "" cmd /c start-social
start "" cmd /c start-web
