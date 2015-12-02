/*
 * Program to sort integer array
 */

#include <stdio.h>

int main()
{
	int arr[10] = {9, 8, 7, 6, 5, 4, 3, 2, 1};
	int i, j, temp;

	for(i = 0; i < 10; i++)
	{
		for(j = 0; j < 10; j++)
		{
			if(arr[j] < arr[j - 1])
			{
				temp = arr[j -1];
				arr[j - 1] = arr[j];
				arr[j] = temp;				
			}
		}
	}


	for(i = 0; i < 10; i++)
		printf("%d\t", arr[i]);	
}
