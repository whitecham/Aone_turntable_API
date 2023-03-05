Version 1.0

:: note ::
This app is built with Python 3.10.
This app uses HTTP, so be sure to run TurntableApp when an HTTP request is made.
To execute the T2D app, Python and the 'requests' Python module should be pre-installed.

:: Usage ::
t2d <IP> <PORT> <PASSWORD> <CMD> <CMD2>

<IP>        : Target turntable IP address
<PORT>      : Target turntable PORT
<PASSWORD>  : Target turntable PASSWORD ('n' or 'N' for no password)
<CMD>       : command for turntable. Please refer to below command list
<CMD2>      : specific value for <CMD>. Please refer to below command list

:: Command list ::

rpt <0 or 1> (0 : off , 1 : on)
    	- ex : t2d 192.168.0.10 9138 n rpt 0")
rpt_dir <0 or 1 or 2> (0 : CW , 1 : CCW , 2 : CCW <-> CW)
	- ex : t2d 192.168.0.10 9138 n rpt 0
rpt_spd <1~10>
	- ex : t2d 192.168.0.10 9138 n rpt_spd 2
rpt_apply
	- ex : t2d 192.168.0.10 9138 n rpt_apply

deg <0 ~ 360>
	- ex : t2d 192.168.0.10 9138 n deg 180
deg_spd <1~10> 
	- ex : t2d 192.168.0.10 9138 n deg_spd 1
deg_apply
	- ex : t2d 192.168.0.10 9138 n deg_apply

info_dir
	- show that current direction 
info_cur_deg
	- show that current degree 
info_tar_deg
	- show that target degree
info_rpt_spd
	- show that Repeat Setting section speed 
info_spd
	- show that Setting section speed 
info_rpt
	- show that repeat value 
info_is_run
	- show that turntable is running or not