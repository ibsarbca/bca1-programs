/*
 * Factorial using recursion
 */

#include <stdio.h>

/*
 * Function to find factorial
 */
int fact(int n)
{
	if(n != 1)
		return n * fact(n - 1);
}

int main()
{
	int num;
	scanf("%d", &num);
	printf("%d\n", fact(num));
}


