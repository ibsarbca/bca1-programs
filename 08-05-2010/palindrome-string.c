/*
 * Check if string is a palindrom
 */

#include <stdio.h>
#include <string.h>

int main()
{
	char *s;
	int  i = 0, reverse_index;
	printf("Enter a string: ");
	scanf("%s", s);

	int length = strlen(s);
	for(i = 0; s[i] != '\0'; i++)
	{
		reverse_index = (length - 1) - i;
		/* LEN - 1 because the last number in an array of say 5
		 * elements is 4
		 */

		if(s[i] != s[reverse_index])
			break;
	}

	if(i == length) /* That is, if our loop doesn't break */
		printf("String is a palindrome\n");
	else
		printf("String is NOT a palindrome\n");

}
