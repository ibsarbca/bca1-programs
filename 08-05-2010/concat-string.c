/*
 * Program to concatenate two strings
 */

#include <stdio.h>

int main()
{

	char A[5] = "hello";
	char B[5] = "world";
	int C[10]; /* Array to store final array */

	int i = 0, j = 0, temp = 0;

	/* First copy A */
	for(j = 0; j < 5; j++)
	{
		C[j] = A[j];
	}

	/* Then copy B*/
	for(j = 5; j < 10; j++)
	{
		/* 
		 * j - LEN, because we want to check indexes from A, which
		 * are stored in 0, 1, 2... which is j - LEN
		 */
		C[j] = B[j - 5];
	}

	for(i = 0; i < 10; i++)
		printf("%c", C[i]);	

	printf("\n");
}
