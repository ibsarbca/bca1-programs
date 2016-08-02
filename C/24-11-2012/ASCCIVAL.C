/*
 * Program print ASCII table
 */

#include<conio.h>
#include<stdio.h>
main()
{
	int i;
	clrscr();

	i = 0;
	while(i < 256)
	{
		printf("\t%c = %d",i,i);
		i++;
	}

	getch();
}
