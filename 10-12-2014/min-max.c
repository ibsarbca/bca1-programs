#include <stdio.h>

/*
 * Program to print max and min between 5 numbers
 */

int main()
{
	int LEN = 5; 
	/* We define such a variable because if we want to change the
	 * length of the array, we only change it here, not everywhere
	 */

	int arr[LEN];
	int i = 0;
	int min = 0, max = 0;
	
	printf("Please input any 5 numbers... \n");
	/* Loop for input */
	for(i = 0; i < LEN; i++)
	{
		scanf("%d",&arr[i]);
	}

	min = max = arr[0];
	/* We do this so min and max are numbers already in the array */
	for(i = 0; i < LEN; i++)
	{
		if(min > arr[i])
			min = arr[i];

		if(max < arr[i])
			max = arr[i];
	}

	printf("The minimum is %d and the maximum is %d\n", min, max);

	return 0;
}
