@echo off
cd /
mkdir wifis
netsh wlan export profile folder="c:\wifis" key=clear

