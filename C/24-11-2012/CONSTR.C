/*
 * Program to concatenate 2 strings
 * without using string.h
 */

#include<conio.h>
#include<stdio.h>

main()
{
	int i;
	char str[10], str1[10];
	clrscr();

	printf("Enter the string 1\n");
	scanf("%s",&str);

	printf("First string= %s\n",str);
	printf("Enter the second string\n");
	scanf("%s",str1);

	printf("Second string=%s\n",str1);
	printf("Concanate two string=%s%s\n",str,str1);

	getch();
	return 0;
}
