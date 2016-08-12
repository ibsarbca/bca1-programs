/*
 * Program to transpose a matrix
 */


#include <stdio.h>

int main()
{
	int arr[2][2], i, j, trans[2][2];

	/* Input loop */
	for(i=0;i<2;i++)
	{
		for(j=0;j<2;j++)
		{
			printf("enter elements [%d][%d] : ",i,j);
			scanf("%d",&arr[i][j]);
		}
		printf("\n");
	}

	printf("Original matrix: \n");
	for(i=0;i<2;i++)
	{
		for(j=0;j<2;j++)
		{
			printf("%d\t",arr[i][j]);
		}
		printf("\n");
	}

	/* Loop to transpose */
	for(i=0;i<2;i++)
	{
		for(j=0;j<2;j++)
		{
			trans[j][i]=arr[i][j];
		}
	}

	/* Output loop */
	printf("Transposed matrix: \n");
	for(i=0;i<2;i++)
	{
		for(j=0;j<2;j++)
		{
			printf("%d\t",trans[i][j]);
		}
		printf("\n");
	}

	return 0;
}
