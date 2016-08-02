/* 
 * Program to merge two arrays and sort in ascending order
 */

#include <stdio.h>

int main()
{
	int LEN = 5;
	int A[5] = { 1, 2, 3, 4, 5 };
	int B[5] = { 4, 5, 6, 7, 8 };

	int C[LEN * 2]; /* Array to store final array */

	int i = 0, j = 0, temp = 0;
	/* First copy A */
	for(j = 0; j < LEN; j++)
	{
		C[j] = A[j];
	}

	/* Then copy B*/
	for(j = LEN; j < LEN * 2; j++)
	{
		/* 
		 * j - LEN, because we want to check indexes from A, which
		 * are stored in 0, 1, 2... which is j - LEN
		 */
		C[j] = B[j - LEN];
	}

	/* Loop to sort array*/
	for(i = 0; i <  LEN * 2; i++)
	{
		for(j = 0; j < LEN * 2; j++)
		{
			if(C[j] < C[j - 1])
			{
				temp = C[j -1];
				C[j - 1] = C[j];
				C[j] = temp;				
			}
		}
	}

	/* Output loop */
	for(i = 0; i < LEN * 2; i++)
		printf("%d\t", C[i]);	
	printf("\n");
}
