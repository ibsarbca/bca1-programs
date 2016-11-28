#include <stdio.h>
#include <string.h>

int main()
{
	char name[50];

	printf("Please enter your name: ");
	scanf("%s", name);

	int length = strlen(name);

	printf("Your name is %d characters long\n", length);
}
