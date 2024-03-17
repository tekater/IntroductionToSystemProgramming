#define _CRT_SECURE_NO_WARNINGS
#include "ServerSocket.h"
#include "ClientSocket.h"
#include<string>

#pragma comment(lib,"WS2_32.lib")

void main()
{
	setlocale(LC_ALL, "");
	CONST INT SIZE_NAME = 32; 
	CHAR sz_username[SIZE_NAME] = "username";
	int nChoise;
	int port = 22000;

	string ipAddress;

	char receiveMessage[MAXSTRLEN]{};
	char sendMessage[MAXSTRLEN]{};

	cout << "1. Start server" << endl;
	cout << "2. Connect to server" << endl;
	cout << "3. Exit" << endl;

	cin >> nChoise;
	switch (nChoise)
	{

	case 1:
	{
		ServerSocket server;
		cout << "Starting server" << endl;
		server.StartHosting(port);
		while (true)
		{
			//cout << "Waiting..." << endl;
			server.ReceiveData(receiveMessage, MAXSTRLEN);
			cout << /*"Received: " <<*/ receiveMessage << endl;
			server.SendDataMessage();
			if (strcmp(receiveMessage, "end") == 0 || strcmp(sendMessage, "end") == 0)
			{
				break;
			}
		}
	}
	break;

	case 2:
	{
		string username;

		//cout << "Enter IP address: "; cin >> ipAddress;
		ipAddress = "127.0.0.1";
		cout << "Enter username: ";   cin >> username;
		ClientSocket client = username;
		client.ConnectToServer(ipAddress.c_str(), port);
		while (true)
		{
			ZeroMemory(sendMessage, sizeof(sendMessage));
			ZeroMemory(receiveMessage, sizeof(receiveMessage));
			strcpy(sendMessage,client.SendDataMessage());
			//cout << "Waiting" << endl;
			if (strstr(sendMessage, "bye"))
			{
				break;
			}
			client.ReceiveData(receiveMessage,MAXSTRLEN);
			cout << /*"Received: "<<*/ receiveMessage << endl;

			/*if (strcmp(receiveMessage, "end") == 0 || strcmp(sendMessage, "end") == 0)
			{
				break;
			}*/
			if (strstr(receiveMessage, "bye"))
			{
				break;
			}
		}
		client.CloseConnection();
	}
	break;
	}
}