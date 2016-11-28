#include <stdio.h>
#include <string.h>

int main()
{
	char applicant_name[40], nf_facutly_name[40];

	printf("Please enter name of the applicant: ");	

	scanf("%s", applicant_name);

	printf("Do they want to be the NF faculty? (Y/N)\n");

	char choice = 'y';

	if(choice == 'y')
		strcpy(nf_facutly_name, applicant_name);

	printf("You are now the facutly for Network Fundamentals\n");
}
