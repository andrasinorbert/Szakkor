@echo off
if NOT exist %1.asm goto exit
tasm %1
if errorlevel 1 goto exit
if exist %1.com del %1.com>NUL
tlink /t %1 
if not exist %1.com got exit
%1.com
:exit