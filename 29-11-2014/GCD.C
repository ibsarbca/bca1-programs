/*
 * Loop to calculate GCD
 */

#include<conio.h>
#include<stdio.h>
int main()
{
	int n1,n2,i,gcd;
	clrscr();
	printf("\nEnter two numbers");
	scanf("%d%d",&n1,&n2);

	/* Loop will run until i is greater than n1 or n2, and stop when
	 * we reach the largest divisor
	 */
	for(i = 1; i <= n1 || i <= n2; i++)
	{
		if(n1 % i == 0 && n2 % i == 0)
		{
			gcd=i;
		}
	}
	printf("gcd=%d",gcd);
	getch();
	
	return 0;
}
