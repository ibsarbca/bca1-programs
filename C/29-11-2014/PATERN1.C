/*
 * Print the following pattern:
 *
 * 1234567
 * 777777
 * 12345
 * 5555
 * 123
 * 33
 * 1
 */

#include<stdio.h>
#include<conio.h>

main()
{
	int i,j;
	clrscr();
	for(i=8;i>1;i--)
	{
		for(j=1;j<i;j++)
		{
			/* Every even line has a repeating pattern, so we print i
			 * since it will remain constant for the line
			 */
			if(i%2!=0)
			{
				printf("%d",i);
			}
			else
			{
				printf("%d",j);
			}
		}
		printf("\n");
	}
	getch();
}
/*1234567
  777777
  12345
  5555
  123
  33
  1*/
