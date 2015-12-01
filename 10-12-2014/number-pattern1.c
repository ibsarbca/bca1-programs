#include <stdio.h>

/*
 * Program to print the following pattern:
 *
 * 1 2 3 4 5 6 7
 * 7 7 7 7 7 7
 * 1 2 3 4 5
 * 5 5 5 5
 * 1 2 3
 * 3 3
 * 1
 *
 */

int main()
{

	int i = 0, j = 0; /* Loop counters */
	int MAX_NUM = 7; /* Maximum numbers */
	
	/* Print first line */
	for(i = 1; i <= MAX_NUM;i++)
	{
		printf("%d ", i);
	}
	printf("\n");

	/* Outer loop for each row */
	for(i = MAX_NUM; i >= 0; i--) 
	{
		/* Inner loops for each individual number */
		if (i % 2 == 0)
		{
			/* If we are on the i-th row where i is EVEN,
			 * print 1 2 3... */
			for(j = 1; j < i; j++)
			{
				printf("%d ", j);
			}
			printf("\n");
		}
		else
		{
			/* If we are on the i-th row where i is ODD,
			 * print 3 3 3... */
			for(j = 1; j < i; j++)
			{
				printf("%d ", i);
			}
			printf("\n");
		}
	}
	return 0;
}

