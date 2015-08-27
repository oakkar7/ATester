# ATester
AT Commands Tool for GSM/GPRS Modem, Modules
Name	: ATester (or) AT command tester tool
version :	Alpha 1.1
By		: oakkar7
web		: http://okelectronic.wordpress.com
host	: https://github.com/oakkar7
license : 

date	: 20 Aug 2015
infos:
This is hale AT command test too for SIMCOM GSM/GPRS modules (tested with SIM90X, SIM300 and SIM800 may also work. 
This is very early alpha test release and use at your own risk.

- Support the following AT commands.
1. AT		AT command test
2. AT+CSQ	GSM Signal strength
3. AT+CREG?	Network Info
4. ATI		Modem/Module informations
5. AT+GMR	Hardware version
6. AT+GSV	Firmware version
7. AT&F		Modem reset
8. AT&W		Configuration Save
9. AT+CPOWD=1 Power Off
10. ATD		Voice Call
11. ATH		HangUp Call
12. AT+CMGS	SMS Sending

- Also sending custom AT commands
- receiving respond string from Modem and display in Hex format

#To be add
SMS Receiving
Manny commands neet to add such as AT+CREG, AT+CGMI, AT+CGMM, AT+CGSN, AT+CGMR, AT+CIMI, AT+CPBR
Decoding respond from modem (Some feedback string need to phrase for more understandable)
GPS? Only for SIMXX8 modules
GPRS support?
Custom AT commands set editing and saving in config files for different modules
