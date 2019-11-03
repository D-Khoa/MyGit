// BaiTapCpp.cpp : Defines the entry point for the console application.
//

//#include "stdafx.h"
#include <iostream>
using namespace std;

int Tong(int n);
int TongBinhPhuong(int n);
float TongPhanSo(int n);
int TinhGiaiThua(int n);

int main()
{
	int n;
	cout << "Tong = " << Tong(10) << endl;
	cout << "Tong mu 2 = " << TongBinhPhuong(10) << endl;
	cout << "Tong phan so = " << TongPhanSo(3) << endl;
	cout << "Nhap n: "; cin >> n;
	cout << "Giai thua " << n << " = " << TinhGiaiThua(n) << endl;

	return 0;
}