#include <stdio.h>

/*
 * Shows you that strings are basically arrays but have special
 * considerations in C.
 */
int main()
{
	char string[5] = {'h', 'e', 'l', 'l', 'o'};

	char name[50] = "ballabh yadav";

	int i = 0;
	for(i = 0; i < 10; i++)
	{
		printf("%c ", name[i]);
	}

	printf("%s\n", name);
	printf("\n");
}
