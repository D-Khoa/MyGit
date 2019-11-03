#include<math.h>

int Tong(int n)
{
	int S = 0;
	for (int i = 0; i <= n; i++)
	{
		S += i;
	}
	return S;
}

int TongBinhPhuong(int n)
{
	int S = 0;
	for (int i = 1; i <= n; i++)
	{
		S += pow(i, 2);
	}
	return S;
}

float TongPhanSo(int n)
{
	float S = 0;
	for (int i = 1; i <= n; i++)
	{
		S += (float)1 / i;
	}
	return S;
}

int TinhGiaiThua(int n)
{
	int S = 1;
	if (n > 1)
		S = n*TinhGiaiThua(n - 1);
	return S;
}

