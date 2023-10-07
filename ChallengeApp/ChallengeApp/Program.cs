using System.Diagnostics.Metrics;

int number = 1995;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

int digit0 = 0;
int digit1 = 0;
int digit2 = 0;
int digit3 = 0;
int digit4 = 0;
int digit5 = 0;
int digit6 = 0;
int digit7 = 0;
int digit8 = 0;
int digit9 = 0;



foreach (char letter in letters)
{
    if (letter == '0')
    {
        digit0++;
    }
    else if (letter == '1')
    { 
        digit1++;
    }
    else if (letter == '2')
    {
        digit2++;
    }
    else if (letter == '3')
    {
        digit3++;
    }
    else if (letter == '4')
    {
        digit4++;
    }
    else if (letter == '5')
    {
        digit5++;
    }
    else if (letter == '6')
    {
        digit6++;
    }
    else if (letter == '7')
    {
        digit7++;
    }
    else if (letter == '8')
    {
        digit8++;
    }
    else if (letter == '9')
    {
        digit9++;
    }
}
Console.WriteLine("Wyniki dla liczby:" + number);
Console.WriteLine("Liczba 0 = " + digit0);
Console.WriteLine("Liczba 1 = " + digit1);
Console.WriteLine("Liczba 2 = " + digit2);
Console.WriteLine("Liczba 3 = " + digit3);
Console.WriteLine("Liczba 4 = " + digit4);
Console.WriteLine("Liczba 5 = " + digit5);
Console.WriteLine("Liczba 6 = " + digit6);
Console.WriteLine("Liczba 7 = " + digit7);
Console.WriteLine("Liczba 8 = " + digit8);
Console.WriteLine("Liczba 9 = " + digit9);
