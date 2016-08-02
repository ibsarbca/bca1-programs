/*
 * Menu driven program to add, subtract, multiply or divide
 */

#include <stdio.h>

int add(int x, int y)
{
	return x + y;
}


int subtract(int x, int y)
{
	return x - y;
}

int multiply(int x, int y)
{
	return x * y;
}

float divide(int x, int y)
{
	if(y == 0)
		return -1;
	else
		return x / y;
}

int main()
{
	int x, y;
	char choice = '0';

	while(choice != 'q')
	{
		
		printf("====== Choose your option =====\n");
		printf("a. Add\n");
		printf("b. Subtract\n");
		printf("c. Multiply\n");
		printf("d. Divide\n");
		printf("q. Quit\n\n");
		
		scanf("%c", &choice);
		if(choice < 66 || choice > 122)
			return;

		printf("choice=%c\n", choice);

		
		switch(choice)
		{
			case 'a':
				printf("Enter 2 nos x and y: ");
				scanf("%d%d", &x, &y);
				printf("Result: %d\n", add(x, y));
				break;

			case 'b':
				printf("Enter 2 nos x and y: ");
				scanf("%d%d", &x, &y);
				printf("Result: %d\n", subtract(x, y));
				break;

			case 'c':
				printf("Enter 2 nos x and y: ");
				scanf("%d%d", &x, &y);
				printf("Result: %d\n", multiply(x, y));
				break;

			case 'd':
				printf("Enter 2 nos x and y: ");
				scanf("%d%d", &x, &y);
				if(y != 0)
					printf("Result: %d\n", multiply(x, y));
				else
					printf("Error: Cannot divide by 0\n");
				break;
			case 'q':
				break;
		}
	}

	return 0;
}

