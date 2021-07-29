if "%1" == "" and "%2" == "" goto NO_ARGS

set HOST=%1
set PORT=%2

:NO_ARGS
set PATH=D:\SteamLibrary\steamapps\common\TreeOfSavior\release\
set HOST=52.58.92.141
set PORT=7001
goto RUN

:RUN
D:
cd %PATH%
Zemyna_x64.exe host:%HOST% port:%PORT%
