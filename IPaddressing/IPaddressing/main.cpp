//#include "main.h"
#define _CRT_SECURE_NO_WARNINGS

#include<Windows.h>
#include"resource.h"
#include<CommCtrl.h>
#include<cstdio>

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, INT nCmdShow)
{
	DialogBox(hInstance, MAKEINTRESOURCE(IDD_DIALOG_MAIN), NULL, (DLGPROC)DlgProc, 0);
}

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{

	case WM_NOTIFY:
		switch (wParam)
		{
		case IDC_IPADDRESS1:

			break;
		}
		break;

	case WM_INITDIALOG:
	{
		HWND hIPaddress  = GetDlgItem(hwnd, IDC_IPADDRESS1);
		HWND hSpinPrefix = GetDlgItem(hwnd, IDC_SPIN_PREFIX);
	}
	break;
	case WM_KILLFOCUS:
	{
		HWND hIPaddress  = GetDlgItem(hwnd, IDC_IPADDRESS1);
		HWND hStaticInfo = GetDlgItem(hwnd, IDC_STATIC_INFO);
		if ((HWND)wParam == hIPaddress)
		{
			DWORD dwIPaddress = 0;
			SendMessage(hIPaddress, IPM_GETADDRESS,0,(LPARAM)&dwIPaddress);
			
			CHAR info[256]{};
			sprintf(info, "%i", dwIPaddress);
			SendMessage(hStaticInfo, WM_SETTEXT, 0, (LPARAM)info);
		}
	}
	break;
	case GetDlgItem(hwnd,IDC_IPADDRESS2):
	{

	}
	case WM_COMMAND:
		break;


		switch (LOWORD(wParam))
		{
			case IDOK:
			{
				HWND hIPaddress  = GetDlgItem(hwnd, IDC_IPADDRESS1);
				HWND hStaticInfo = GetDlgItem(hwnd, IDC_STATIC_INFO);
				if ((HWND)wParam == hIPaddress)
				{
					DWORD dwIPaddress = 0;
					SendMessage(hIPaddress, IPM_GETADDRESS, 0, (LPARAM)&dwIPaddress);
					DWORD first = FIRST_IPADDRESS(dwIPaddress);
					DWORD dwMask = 0;
					if (first < 128)
					{
						dwMask = 0xFF000000;
					}
					else if (first >= 128 && first < 192)
					{
						dwMask = 0xFFFF0000;
					}
					else if (first >= 192 && first < 224)
					{
						dwMask = 0xFFFFFF00;
					}
					SendMessage(GetDlgItem(hwnd,IDC_IPADDRESS2), )
					CHAR info[256]{};
					sprintf(info, "%i", dwIPaddress);
					SendMessage(hStaticInfo, WM_SETTEXT, 0, (LPARAM)info);
				}
			}
				break;
			case IDCANCEL: EndDialog(hwnd, 0); break;
		}


		{
		default:
			break;
		}
	}
}
