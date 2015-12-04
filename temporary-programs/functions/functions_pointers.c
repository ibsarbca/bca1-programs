#include <stdio.h>

void create_array(int arr[])
{
	int i;
	printf("Creating array...\n");
	for(i = 0; i < 10; i++)
		arr[i] = i;
}

void print_array(int n, int arr[])
{	
	int i;
	
	for(i = 0; i < n; i++)
		printf("%d\n", arr[i]);
}

void change_array(int arr[])
{	
	arr[7] = 70;
	
	arr[9] = 90;
	
	arr[8] = arr[1] + arr[9];
}


main()
{
	int arr[] = {0,1,2,3,4,5,6,7,8,9};
	
	int x = 0;
		
	change_array(arr);
	print_array( 5, arr);
 	create_array(arr);
	print_array(10, arr);	
}