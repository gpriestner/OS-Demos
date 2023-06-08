
#include <process.h>
#include <windows.h>
#include <iostream>
using namespace std;

long i = 0;
CRITICAL_SECTION cs;

void fn(void*)
{
	//MessageBox(0, L"Start", L"Thread", MB_OK);
	for (int c = 0; c < 100000000; ++c)
	{
		EnterCriticalSection(&cs);
	    ++i;
		LeaveCriticalSection(&cs);
	}
	MessageBox(0, L"Finished", L"Thread", MB_OK);
}


void main()
{
	InitializeCriticalSection(&cs);
	_beginthread(fn, 0, 0);
	_beginthread(fn, 0, 0);
	_beginthread(fn, 0, 0);

	MessageBox(0, L"Print i", L"Main Thread", MB_OK);

	cout << "Value of i: " << i << endl;

	MessageBox(0, L"End", L"Main Thread", MB_OK);
	DeleteCriticalSection(&cs);
}
