#include <stdio.h>

void sum_n(int n)
{
	int i = 0;
	int sum = 0; 
	for(i = 0; i < n; i++)
		sum += i;

	printf("%d\n", sum);
}


// <return_type> <function_name>([datatype param1], [datatype param])
// {
// }


int main()
{
	sum_n(10);
	sum_n(20);
}
