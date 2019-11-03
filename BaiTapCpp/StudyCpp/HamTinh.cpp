using namespace std;
#include <iostream>
#include <math.h>

int GiaiThua(int n)
{
	int S = 0;
	if (n > 1)
		S = n*GiaiThua(n - 1);
	return S;
}