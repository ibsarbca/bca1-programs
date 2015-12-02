/**
 * Program to check if a digit entered is a palindrome
 * Which means if the original and reverse numbers are the same
 */

#include <stdio.h>

int main()
{
	int LEN = 5;
	int input_num, digits_array[LEN];
	int i; /* Loop Counter */
	int reverse_index; 
	/* Index of the number in reverse */

	printf("Please enter a number (maximum 5 digits):\n");
	scanf("%d", &input_num);


	while(input_num > 0)
	{
		digits_array[i] = input_num % 10;
		i++;
		/* Also increment i so that we store in the next 
		 * input_number in the array
		 */

		input_num = input_num / 10;
	}

	for(i = 0; i < LEN; i++)
	{
		reverse_index = (LEN - 1) - i;
		/* LEN - 1 because the last number in an array of say 5
		 * elements is 4
		 */

		if(digits_array[i] != digits_array[reverse_index])
			break;
	}

	if(i == LEN) /* That is, if our loop doesn't break */
		printf("The reverse of the digits is the same\n");
	else
		printf("The reverse of the digits is NOT the same\n");


	return 0;
}
