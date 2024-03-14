#include<iostream>
#include<WS2tcpip.h> //Содержит функции для работы с адресами
#include<WinSock2.h> //Содержит объявления для работы с протоколами

#pragma comment(lib,"WS2_32.lib")

using namespace std;

void main()
{
	setlocale(LC_ALL, "");
	//const int MAXSTRLEN = 255;

	SOCKET _socket;			// этот сокет будет прослушивать порт
	//SOCKET accept_socket;	// будет принимать подключения от клиентов

	sockaddr_in addr;		// Адрес, который будет прослушивать сервер

	// Создаём и инициализируем сокет:

	WSADATA wsaData;
	
	WSAStartup(MAKEWORD(2, 2), &wsaData);
	_socket = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);
	addr.sin_family = AF_INET; // AF_INET - IPv4
	inet_pton(AF_INET, "0.0.0.0", &addr.sin_addr); // задаём прослушиваемый IP-Адрес

	addr.sin_port = htons(20000);
	// После того как адрес и порт указаны, их нужно привязать к сокету
	bind(_socket, (SOCKADDR*)&addr, sizeof(addr));
	listen(_socket, 1);
	cout << "Server started" << endl;

	//При подключении клиента создается ещё один сокет:
	SOCKET accept_socket = accept(_socket, NULL, NULL);

	const int MAXSTRLEN = 255;
	char buffer[MAXSTRLEN] = {};
	int i = recv(accept_socket, buffer, MAXSTRLEN, 0);
	cout << buffer << endl;
	const char text[] = "Hello from Server!";
	send(accept_socket, text, strlen(text), 0);

	//Закрываем сокеты:
	closesocket(accept_socket);
	closesocket(_socket);

	//Освобождаем ресурсы:
	WSACleanup();

	system("pause");
}