/*
 * Program to print a table
 */

#include <stdio.h>

int main()
{
	int i = 0, j = 0;
	for(i = 1; i < 11; i++)
	{
		for(j = 2; j < 11; j++)
		{
			printf("%d ", i*j);
		}
		printf("\n");
	}
}

