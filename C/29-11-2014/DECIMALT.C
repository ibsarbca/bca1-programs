/*
 * Program to convert decimal to binary
 */

#include <conio.h>
#include <stdio.h>

int main()
{
	long int num,d=0,n,p=1;
	clrscr();
	printf("Enter the binary no");
	scanf("%ld",&num);

	/* Loop takes each digit and divides by 2, if the not 0,
	 * then , else 1
	 */
	while(num>0)
	{
		n = num % 10;
		d = d + n * p;
		p = p * 2;
		num = num / 10;
	} /* End while*/

	printf("Decial=%ld\n",d);
	getch();

	return 0;
}
