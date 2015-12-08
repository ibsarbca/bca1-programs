#include <stdio.h>

/**
 * This functions shows you an example of changing where a pointer is
 * pointing to.
 */
void add_y()
{
	int x = 10;	
	int *px;
	px = &x;

	int y = *px;
	printf("y = %d\n", y);
}

/**
 * This function shows you what happens when you change the value of
 * the variable.
 */
int change_x()
{
	int x = 10;
	int *px;
	px = &x;

	x = 20;
	printf("*px = %d\n", *px);
}

/**
 * This function increments the value of *px
 */
int increment_px()
{
	int x = 9000;
	int *px;
	px = &x;

	*px = *px + 1;
	
	printf("*px = %d\n", *px);
}

/*
 * Shows you the difference between *pointer, just writing the pointer
 * name and what & before a variable gives you
 */
int show_pointers()
{
	int x = 10;
	int *ptr_x; // Declaring that this is a pointer.

	ptr_x = &x;
	// This is where the pointer will POINT to.

	printf("*ptr_x = %d\n", *ptr_x);
	printf("ptr_x = %u\n", ptr_x);
	printf("&x = %u\n", &x);
}

/*
 * Shows you how to increment the VALUE of the variable that a pointer
 * points to. 
 */
int increment_px_2()
{
	int x = 10;
	int *some_pointer;
	some_pointer = &x;
	printf("some_pointer = %u\n",some_pointer);
	++*some_pointer;
	printf("some_pointer = %d\n",*some_pointer);
}

/*
 * Shows you the relationship between arrays and pointers
 */
int array_and_pointers_1()
{
	int arr[3] = { 10, 20, 30 };
	int *px;
	px = &arr[0];
	
	printf("arr [0] = %d\n", *px);
	printf("address of px = %u\n", px);
	printf("value of px = %u\n", *px);
	printf("Incrementing address... \n");
		
	px = px + 1;
	
	printf("address of px = %u\n", px);
	printf("value of px = %u\n", *px);	
}

/*
 * Shows you what happens when you increment the pointer that points
 * to a value in an array
 */
int increment_in_array()
{
	float arr[3] = {10.1, 20.1, 30.1};
	float *px;
	px = &arr[0];
	
	printf("*px = %f\n", *px);
	*px = *px + 1;
	printf("*px = %f\n", *px);
}

/*
 * Shows you more information about arrays and pointers
 */
int array_and_pointers_2()
{
	int arr[3] = {10, 20, 30};
	int *px;
	px = arr; // = &arr[0];
	
	printf("*px = %d\n", *px);	
	//px = px + 2;	
	printf("*px = %d\n", *px);	
	
	// We can also do this:
	printf("arr[0] = %d\n", arr[0]);
	printf("px[0] = %d\n", px[0]);	
}

/*
 * How to use strings and pointers
 */
int strings_and_pointers()
{
	char arr[] = "hello";
	char *char_ptr;
	char_ptr = &arr[2];
	
	printf("arr[2] = %c\n", *char_ptr);
}

/*
 * Shows you another way to declare a string. Here, we skip a few
 * steps because *s1_ptr and s1_ptr[SOME_NUMBER] is the same. 
 * Then we increment the value s1_ptr, so it keeps pointing to the
 * next address, until the value AT that address is '\0'
 */
int string_length(char *s1)
{	
	char *s1_ptr;
	s1_ptr = &s1[0];// &s1[0];
	
	int count_of_characters = 0;
	while(*s1_ptr != '\0') {
		s1_ptr++;
		
		count_of_characters++;
	}
	
	printf("length = %d\n", count_of_characters);
}

/*
 * Shows you how pointers can also point to other pointers. Notice how
 * *ipp points to the address of the POINTER ip. Since pointers are a
 * kind of variable, they also have their own address.
 */
void pointer_to_pointer()
{
	int i = 5, j = 6, k = 7;
	
	int *ip;
	int *ip2;
	
	ip = &i;
	ip2 = &j;
	
	int **ipp;
	ipp = &ip;
	
	*ipp = &k;
	
	printf("**ipp = %d\n", **ipp);
}

/*
 * Shows you an example of how you pass pointers to a function. The
 * advantage of this is that when we pass variables that are declared
 * into the swap() function using pointers, this function directly
 * manipulates those variables, not copies (or duplicates) of those
 * variables.
 *
 * This is known as call-by-reference in C.
 */ 
void swap(int *pa, int *pb)
{
	printf("IN SWAP: \n");
	printf("addr of a = %u, addr of b = %u\n\n", pa, pb);
	int temp = *pa;
	*pa = *pb;
	*pb = temp;
}

int main()
{
	int a = 10, b = 20;
	printf("IN MAIN: \n");
	printf("addr of a = %u, addr of b = %u\n\n", &a, &b);
	
	swap(&a, &b);
	
	printf("a = %d, b = %d\n", a, b);
	
	
	pointer_to_pointer();
}
