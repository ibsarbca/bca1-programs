/*
 * Program to print a pattern
 */

#include <stdio.h>

main()
{
	int i,j;
	/*
	 * We're using values around 65 because the ASCII values for
	 * capital letters begin from there
	 */
	for(i = 65; i < 70; i++)
	{
		printf("%d ", i - 64);
		/*
		 * using %c here makes it type the letter with the ASCII value
		 * instead of the number
		 */
		for(j = 65;j <=  i; j++)
		{
			printf("%c", j);
		}
		printf("\n");
	}
}

