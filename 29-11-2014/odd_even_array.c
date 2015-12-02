/*
 * This program separates the odd and even numbers entered by a user
 * into arrays
 */

#include <stdio.h>

int main()
{
	int LEN = 5;
	int arr[LEN];
	int odd_array[LEN], even_array[LEN];
	int i = 0;

	printf("Enter %d numbers: \n", LEN);
	for(i = 0; i < LEN; i++)
	{
		scanf("%d", &arr[i]);
		if (arr[i] % 2 != 0)
			odd_array[i] = arr[i];
		else
			even_array[i] = arr[i];
	}

	for(i = 0; i < LEN; i++)
	{
		printf("Odd[%d] = %d\tEven[%d] = %d\n", i, odd_array[i], i, even_array[i]);
	}
}
