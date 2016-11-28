#include <stdio.h>
#include <string.h>

int main()
{
	char number[40], faculty_number[40];

	printf("Please enter your telephone number: ");

	scanf("%s", number);

	strcpy(faculty_number, number);

	printf("The telephone number of the faculty is now: %s\n", faculty_number);
}
