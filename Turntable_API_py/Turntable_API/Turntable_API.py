
from pickle import TRUE
import sys
import requests ,json



def cmd_help():
    print('--------  Usage  --------')
    print()
    print('show')
    print(' : shows that current ip and port setting.')   
    print()
    print('setip <IP>')
    print(' : set ip to access. ex)setip 192.168.1.50')
    print('setport <port>') 
    print(' : set port to access. ex) setport 9138')
    print('setpwd <password>')
    print(' : set password to access in case the pwd is set. ex) setpwd 1234')
    print()
    print('rep CW')
    print(' : rotate the table to CW repeatedly')
    print('rep CCW')
    print(' : rotate the table to CCW repeatedly')
    print('rep CCWCW')
    print(' : rotate the table to CCW then CW repeatedly')
    print('go <degree>')
    print(' : rotate the table to <degree> ex) go 180')

def cmd_help_non_while():
    print('--------  Usage  --------')
    print()
    print("t2d <IP> <PORT> <PASSWORD> <CMD> <CMD2>")
    print(" <IP>        : Target turntable IP address")
    print(" <PORT>      : Target turntable PORT")
    print(" <PASSWORD>  : Target turntable PASSWORD ('n' or 'N' for no password)")
    print(" <CMD>       : command for turntable. Please refer to below command list ") 
    print(" <CMD2>      : specific value for <CMD>. Please refer to below command list ")
    print()
    print("-----  Command list  -----")
    print()
    print(" : rpt <0 or 1> (0 : off , 1 : on)")
    print("    ex : t2d 192.168.0.10 9138 n rpt 0")
    print(" : rpt_dir <0 or 1 or 2> (0 : CW , 1 : CCW , 2 : CCW <-> CW)")
    print("    ex : t2d 192.168.0.10 9138 n rpt 0")
    print(" : rpt_spd <1~10> ")
    print("    ex : t2d 192.168.0.10 9138 n rpt_spd 2")
    print(" : rpt_apply")
    print("    ex : t2d 192.168.0.10 9138 n rpt_apply")
    print()
    print(" : deg <0 ~ 360>")
    print("    ex : t2d 192.168.0.10 9138 n deg 180")
    print(" : deg_spd <1~10> ")
    print("    ex : t2d 192.168.0.10 9138 n deg_spd 1")
    print(" : deg_apply")
    print("    ex : t2d 192.168.0.10 9138 n deg_apply")
    print()
    print(" : info_dir")
    print("    - show that current direction ")
    print(" : info_cur_deg")
    print("    - show that current degree ")
    print(" : info_tar_deg")
    print("    - show that target degree")
    print(" : info_rpt_spd")
    print("    - show that Repeat Setting section speed ")
    print(" : info_spd")
    print("    - show that Setting section speed ")
    print(" : info_rpt")
    print("    - show that repeat value ")
    print(" : info_is_run")
    print("    - show that turntable is running or not ")





def cmd_interpret(cmd,extra_var):
    # repeat
    if cmd == 'rpt':
        rep_flag = extra_var
        if(rep_flag == '1' or rep_flag == '0'):
            result = "repeat="+rep_flag
        else:
            print("rep value should be 0 or 1 (0 : off , 1 : on)")
            result = '0'

    elif cmd == 'rpt_dir':
        direction = extra_var
        if(direction == '0' or direction == '1' or direction == '2'):
            result = 'direction='+direction
        else:
            print("rep_dir value should be 0 ~ 2 (0:CW , 1: CCW , 2: CCW <->CW")
            result = '0'

    elif cmd == 'rpt_spd':
        rep_spd = extra_var
        try:
            int_rep_spd = int(rep_spd)
            if(int_rep_spd >= 1 and int_rep_spd <=10):
                result = 'tar_spd_rpt='+rep_spd
            else:
                print("rep_spd value should be 1~10")
                result = '0'
        except:
            print("rep_spd value should be 1~10")
            result = '0'

    elif cmd == 'rpt_apply':
        result = "set_mem(40011,1)"
    # deg
    elif cmd == 'deg':
        tar_deg = extra_var
        try:
            int_tar_deg = float(tar_deg)
            if(int_tar_deg >= 0.0 and int_tar_deg <=360.0):
                result = "tar_deg="+tar_deg
            else:
                print("deg value should be 0.0 ~ 360.0")
                result = '0'
        except:
            print("deg value should be 0.0 ~ 360.0")
            result = '0'
    elif cmd == 'deg_spd':
        tar_spd = extra_var
        try:
            int_tar_spd = int(tar_spd)
            if(int_tar_spd >= 1 and int_tar_spd <=10):
                result = 'tar_spd='+tar_spd
            else:
                print("deg_spd value should be 1 ~ 10")
                result = '0'
        except:
            print("deg_spd value should be 1 ~ 10")
            result = '0'
    elif cmd == 'deg_apply':
        result = 'set_mem(40001,1)'
    # info
    elif cmd == 'info_dir':
        result = 'vars_to_json("direction")'
    elif cmd == 'info_cur_deg':
        result = 'vars_to_json("cur_deg")'
    elif cmd == 'info_tar_deg':
        result = 'vars_to_json("tar_deg")'
    elif cmd == 'info_rpt_spd':
        result = 'vars_to_json("tar_spd_rpt")'
    elif cmd == 'info_spd':
        result = 'vars_to_json("tar_spd")'
    elif cmd == 'info_rpt':
        result = 'vars_to_json("repeat")'
    elif cmd == 'info_is_run':
        result = 'vars_to_json("isBusy")'
    else:
        cmd_help_non_while()
        result = '0'


    return result

def response_interpret(txt):
    #print(txt)
    data = json.loads(txt)
    http_result = data["success"]

    if(http_result == True):
        
        #print(type(http_vars))
        #print(http_vars)
        try:
            http_vars = data["vars"]
            if(len(list(http_vars.keys())) != 0):
                vars_str = list(http_vars.keys())
                if(vars_str[0] == 'direction'):
                    val = http_vars["direction"] 
                    if(val == 0):
                        print("0 (CW)")
                    elif(val == 1):
                        print("1 (CCW)")
                    elif(val == 2):
                        print("2 (CCW<->CW)")
                elif(vars_str[0] == 'cur_deg'):
                    val = float(http_vars["cur_deg"])
                    print(str(val * 0.0144) + " deg")
                elif(vars_str[0] == 'tar_deg'):
                    val = http_vars["tar_deg"] 
                    print(str(val) + " deg")
                elif(vars_str[0] == 'tar_spd_rpt'):
                    val = http_vars["tar_spd_rpt"] 
                    print(val)
                elif(vars_str[0] == 'tar_spd'):
                    val = http_vars["tar_spd"] 
                    print(val)
                elif(vars_str[0] == 'repeat'):
                    val = http_vars["repeat"] 
                    print(val)
                elif(vars_str[0] == 'isBusy'):
                    val = http_vars["isBusy"] 
                    if(val == 0):
                        print('0 (ready)')
                    elif(val == 1):
                        print('1 (running)')
        except:
            print("ok")

    elif(http_result == False):
        try:
            http_error = data["error"]
            http_error_code = http_error["code"]
            if(http_error_code == '3012'):
                print("Incorrect password")
            elif(http_error_code == '4011'):
                print("Unknown command")
        except:
            print("fail")
    
    return

def main2():
    print('main!')
    prefix = "http://"
#    url = prefix+IP+":"+PORT
#    print (url)
    response = requests.get('http://172.30.1.20:9138/script//direction=1;repeat=1;tar_deg=259.4;set_mem(40011,1)')
    print(response)


def main():
    try:
        IP = sys.argv[1]
    except:
        cmd_help_non_while()
        return

    try:
        PORT = sys.argv[2]
    except:
        cmd_help_non_while()
        return
    try:
        PASSWD = sys.argv[3]
    except:
        URL = "http://"+IP+":"+PORT
        response = requests.get(URL)
        print(response)
        return

    if(PASSWD == 'n' or PASSWD == 'N'):
        URL = "http://"+IP+":"+PORT+"/script//"
    else:
        URL = "http://"+IP+":"+PORT+"/script/"+PASSWD+"/"

    try:
        CMD = sys.argv[4]
    except:
        cmd_help_non_while()
        return

    try:
        ex_val = sys.argv[5]
    except:
        if(CMD == 'rpt_apply' or CMD == 'deg_apply' or 
           CMD == 'info_dir' or CMD == 'info_cur_deg' or
           CMD == 'info_tar_deg' or CMD == 'info_rpt_spd' or
           CMD == 'info_spd' or CMD == 'info_rpt' or CMD =='info_is_run'):
            ex_val = ''
        else:
            cmd_help_non_while()
            return

    t_cmd = cmd_interpret(CMD,ex_val)

    if(t_cmd == '0'):
        return

    URL = URL+t_cmd
    response = requests.get(URL)
    text = response.text
    response_interpret(text)

if __name__ == "__main__":
    main()