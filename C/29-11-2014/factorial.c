/*
 * Program to print factorial of numbers 1..10
 */

#include <stdio.h>

int main()
{
	int i = 0, j = 0, fact;
	for(i = 1; i <= 10; i++)
	{
		fact = 1; /* Reset factorial to 1 for each number */

		/* Loop to calcuate factorial for number i */
		for(j = i; j > 1; j--)
		{
			fact = fact * j;
		}

		printf("Factorial of %d = %d\n", i, fact);
	}
}
