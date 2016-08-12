#include<conio.h>
#include<stdio.h>
#include<string.h>
main()
{
	struct Account{
		int accno;
		char acctype;
		char name[25];
		float bal;
	};
	struct Account str[20];
	int i;
	clrscr();
	for(i=1;i<=10;i++)
	{
		printf("Enter the account no\n");
		scanf("%d",&str[i].accno);
		printf("Enter the account type=\n");
		scanf("%s",&str[i].acctype);
		printf("Enter the name=\n");
		scanf("%s",&str[i].name);
		printf("Enter balance=\n");
		scanf("%d",&str[i].bal);
	}

	getch();
}
