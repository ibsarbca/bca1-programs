/*
 * Program to print the following pattern
 * 1 A 
 * 2 A B
 * 3 A B C
 * 4 A B C D
 * 5 A B C D E
 */

#include <conio.h>
#include <stdio.h>

main()
{
	int i,j;
	clrscr();
	for(i=1;i<=5;i++)
	{
		printf("%d",i);
		for(j = 1; j <= i; j++)
		{
			printf("%c",'A' + j - 1);
		}
		printf("\n");
	}
	getch();
}
