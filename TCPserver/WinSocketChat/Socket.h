#pragma once
#include<iostream>
#include<WS2tcpip.h>
#include<WinSock2.h>

#pragma comment(lib,"WS2_32.lib")

using namespace std;

CONST INT MAXSTRLEN = 255;

class Socket
{
protected:
	WSADATA wsaData;
	SOCKET _socket;
	SOCKET acceptSocket;
	sockaddr_in addr;
	char* username;
public:
	Socket();
	~Socket();

	bool SendData   (char* data);
	bool ReceiveData(char* data, int size);

	void CloseConnection();
	void SendDataMessage();
	void SetUsername(char* name);

};