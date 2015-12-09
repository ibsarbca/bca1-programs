/*
 * Program to concat two strings without string.h
 */

#include <stdio.h>

/* First we simply declare a function */
void concat(char a[], char b[]);

main()
{
	char a[20], b[20];
	printf("Enter first string: ");
	scanf("%s", a);
	printf("Enter second string: ");
	scanf("%s", b);

	concat(a, b);
	printf("%s\n", a);
}

void concat(char a[20], char b[20])
{
	int i = 0, j = 0;
	for(i = 0; a[i] != '\0'; i++)
	{
		j++;
	}
	for(i = 0; b[i] != '\0'; b++)
	{
		a[j] = b[i];
		j++;
	}
	a[j] = '\0';
}
