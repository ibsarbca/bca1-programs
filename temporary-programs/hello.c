#include <stdio.h>

int main()
{
	printf("Hello, what is your name?");
	char name[50];

	scanf("%s", name);

	printf("Hello %s, how are you doing today?\n", name);
}
