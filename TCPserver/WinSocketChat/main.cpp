#include "ServerSocket.h"
#include "ClientSocket.h"
#include<string>

#pragma comment(lib,"WS2_32.lib")

void main()
{
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
			cout << "Waiting..." << endl;
			server.ReceiveData(receiveMessage, MAXSTRLEN);
			cout << "Received: " << receiveMessage << endl;
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
		cout << "Enter IP address: "; cin >> ipAddress;
		ClientSocket client;
		client.ConnectToServer(ipAddress.c_str(), port);
		while (true)
		{
			client.SendDataMessage();
			cout << "Waiting" << endl;
			client.ReceiveData(receiveMessage,MAXSTRLEN);
			cout << "Received: "<< receiveMessage << endl;
			if (strcmp(receiveMessage, "end") == 0 || strcmp(sendMessage, "end") == 0)
			{
				break;
			}
		}
		client.CloseConnection();
	}
	break;
	}
}