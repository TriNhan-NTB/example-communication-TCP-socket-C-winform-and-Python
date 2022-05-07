import socket
import time

listensocket  = socket.socket()

HOST = "127.0.0.1"
PORT = 8000

listensocket.bind((HOST,PORT))
listensocket.listen(9)

print(f"Sever started at {HOST} on port {PORT}")
msg_send = 'PC_SEND'
while(True):
    client, addr = listensocket.accept()

    try:
        print("Conected by", addr)
        while client:
            try:
                # nhận gói dữ liệu dạng byte
                data = client.recv(1024)
                # giải mã ra
                signal_str = data.decode().rstrip()
                print("Client: " + signal_str)

                if signal_str == "Write":
                    data = client.recv(1024)
                    str_data_recv = data.decode().rstrip()
                    print("Data Recv " + str_data_recv)

                elif signal_str == "Read":
                    client.send(bytes(msg_send, 'ascii'))
            except:
                break

    finally:
        client.close()
s.close()
