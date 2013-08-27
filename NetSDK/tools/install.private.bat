:usage - install.bat

@echo off
setlocal
if "%1" == "" goto UrlPrompt
if "%2" == "" goto UrlPrompt
set webappurl=%1
set siteurl=%2
goto Main

:UrlPrompt
echo Enter URL of the tournament site web application (e.g., http://tournament.amf.com):
set /p webappurl=
echo.
echo Enter the relative URL of the tournament site collection (e.g., /):
set /p siteurl=
set siteurl=%webappurl%%siteurl%
echo Enter the path to the Tournament.wsp file (e.g., "C:\temp\"):
set /p wspPath=

:Main
set stsadm="%programfiles%\common files\microsoft shared\web server extensions\12\bin\stsadm.exe"

echo Deploying solution to %siteurl%
@echo on

%stsadm% -o deactivatefeature -filename "TournamentDataEntry\feature.xml" -url "%siteurl%" -force

%stsadm% -o retractsolution -name AMFConnect.Tournament.wsp -url %webappurl% -immediate
%stsadm% -o execadmsvcjobs
%stsadm% -o deletesolution -name AMFConnect.Tournament.wsp -override

%stsadm% -o execadmsvcjobs
iisreset


%stsadm% -o addsolution -filename %wspPath%AMFConnect.Tournament.wsp
%stsadm% -o execadmsvcjobs
%stsadm% -o deploysolution -name AMFConnect.Tournament.wsp -url %webappurl% -allowGACDeployment -allowCASpolicies -force -immediate
%stsadm% -o execadmsvcjobs
iisreset

%stsadm% -o activatefeature -filename "TournamentDataEntry\feature.xml" -url "%siteurl%" -force

:End
@pause