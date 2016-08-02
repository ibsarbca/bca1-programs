/*
 * Program to change to uppercase and reverse
 */

#include <stdio.h>
#include <string.h>

int main()
{
	char *s;
	printf("Enter a string: ");
	gets(s);

	printf("The string in UPPERCASE is %s\n",strupr(s));

	printf("Enter a string: ");
	gets(s);
	printf("The string in reverse is %s\n",strrev(s));
}
