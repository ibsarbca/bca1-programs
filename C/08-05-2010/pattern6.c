/*
 * Program to print pattern
 * 1
 * 22
 * 333
 * 4444
 */

int main()
{
	int i, j;

	for(i = 5; i > 1; i--)
	{
		for(j = 1; j < i; j++)
		{
			/* Every even line has a repeating pattern, so we print i
			 * since it will remain constant for the line
			 */
			printf("%d",i);
		}
		printf("\n");
	}
}
