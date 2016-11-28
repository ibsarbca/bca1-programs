#include <stdio.h>

int add(int, int);
int drawline(int);
int main()
{
	int x = 2, y = 4;
	int sum = add(2, 4);
	printf("sum: %d\n", add(x, y));
	int return_of_drawline = drawline(3);
	printf("drawline = %d\n", return_of_drawline);
	printf("%d\n", drawline(add(3,4)));

	drawline(add(2, 4));
}

int add(int num1, int num2)
{
	int sum = num1 + num2;
	return sum;
}

int drawline(int x)
{
	int i = 0;

	for(i = 0; i < x; i++)
		printf("x");

	printf("\n");
	return 0;
}

