#include <iostream>

inline int max(int a, int b, int c)
{
	return a > b ? a > c ? a : c : b > c ? b : c;
}

int main()
{
	int a = 10, b = 20, c = 30;

	std::cout << max(a, b, c) << std::endl;
}
