/*
 * Program to count vowels in a string
 */
#include <conio.h>
#include <stdio.h>
#include <string.h>

int main()
{
	char line[100];
	int vowels = 0 , i;
	clrscr();

	printf("Enter the sentence\n");
	gets(line);
	for(i=0;line[i]!='\0';i++)
	{
		if(line[i]=='a'||line[i]=='e'||line[i]=='i'||line[i]=='o'||line[i]=='u')
		{
			vowels++;
		}
	}
	printf("%d",vowels);
	getch();
	
	return 0;
}
