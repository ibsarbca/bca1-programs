/* 
 * Program to input ten records in a structure
 */

#include <stdio.h>
#include <string.h>

main()
{

	int LEN = 2;
	struct Account{
		int accno;
		char acctype;
		char name[25];
		float bal;
	};
	struct Account account[LEN];
	int i;

	/* Input loop */
	for(i = 0; i < LEN; i++)
	{
		printf("Enter the account no\n");
		scanf("%d",&account[i].accno);

		printf("Enter the account type=\n");
		scanf("%s",&account[i].acctype);

		printf("Enter the name=\n");
		scanf("%s",&account[i].name);

		printf("Enter balance=\n");
		scanf("%d",&account[i].bal);
	}

	/* Output loop */
	for(i = 0; i < LEN; i++)
	{
		printf("Account number: %d\n", account[i].accno);
		printf("Account Type: %s\n", account[i].acctype);
		printf("Account Name: %s\n", account[i].name);
		printf("Account Balance: %d\n", account[i].bal);

		printf("\n");
	}
}
