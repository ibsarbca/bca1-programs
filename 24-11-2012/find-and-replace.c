#include <stdio.h>
#include <string.h>

void findAndReplace(char a[], char orig, char replacement)
{
	int len = strlen(a);
	int i = 0;

	for(i = 0; i < len; i++)
	{
		if(a[i] == orig)
		{
			a[i] = replacement;
		}
	}
}

int main()
{
	char string[] = "find-and-replace";
	printf("%s\n", string);
	findAndReplace(string, '-', '_');
	printf("%s\n", string);
}
