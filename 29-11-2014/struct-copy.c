/*
 * Program to copy contents of one structure into another
 */

#include <stdio.h>

int main()
{
	struct POINT {
		int x;
		int y;
	} a, b;

	a.x = 10;
	a.y = 20;
	b.x = 30;
	b.y = 40;

	a = b;

	printf("a.x = %d, a.y = %d\n", a.x, a.y);	

}
