#include <iostream>
#include <exception>
#include <string>


using namespace std;

int countDigits(int num)
{
    int i = 0;
    while (num > 0)
    {
        num = num / 10;
        i++;
    }

    return i;
}

int main() 
{
    int num = 0;
    string input_string;
    

    cout << "Enter number:" << endl;
    cin >> input_string;

    int i = 0;

    const char* input_string_arr[256];

    char c = input_string_arr[0];
    while(1)
    {
        input_string_arr = input_string.c_str();

        while(c != '\0')
        {
            try
            {
                c = input_string_arr[i];
                if (!isdigit(c) && c != '\0')
                {
                    throw "Error. Enter a digit only.";
                }
                else
                {
                    i++;
                }
            }
            
            catch(const char* msg)
            {
                // Basically reset the program.
                cout << msg << endl;
                i = 0;
                cin >> input_string;
                c = input_string_arr[0];
            }
        } // End while loop to check characters

        cout << countDigits(atoi(input_string.c_str())) << endl;
        break;

    } // end main while loop
    
}