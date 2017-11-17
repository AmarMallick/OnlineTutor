@echo off

REM - Note that targets are run using go.cmd /t:<name> 
REM - Properties can be overriden with the /p:<name>=<value> command line parameter

@call msbuild OnlineTutor.targets %*  