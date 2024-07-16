using ConsoleApp;


Demos demos = new Demos();
//demos.Strings();
//demos.NumbersFormatting();
//demos.Numbers();
//demos.Arrays();
//demos.IfElse();

//Console.ReadLine();



Console.WriteLine("Podaj bok kwadratu:");
string input = Console.ReadLine();

int side;
bool parseSuccess = int.TryParse(input, out side);

if (!parseSuccess)
{
    Console.WriteLine("Błędna wartość!");
}
else
{

    //switch - przyjmuje parametr, kóry jest porównywany z listą przypadków (case)
    switch (side)
    {
        //case - rozpatrywany przypadek
        //wiele case'ow może być przypisanych do tego samego kodu
        case < 0:
            //kod wykonywany jest od case do break - nie ma potrzeby stosowaniea klamerek {}
            //case musi kończyć się instrukją break - przerywająca wykonywanie swticha
            Console.WriteLine("Nie mogę policzyć obwodu z ujemnego rozmiaru");
            break;
        case > 0:
            Console.WriteLine($"Kwadrat ma obwód {side * 4}");
            break;
        //default - odpowiedniek else, czyli wykonanie kodu, jeśli nie znaleziono odpowiedniego case
        default:
            Console.WriteLine("Kwadrat nie instnieje");
            break;
    }
}



Console.WriteLine("podaj wartość A:");
string a = Console.ReadLine();
Console.WriteLine("podaj wartość B:");
string b = Console.ReadLine();

float valueA, valueB;

if (!(float.TryParse(a, out valueA) && float.TryParse(b, out valueB)))
{
    Console.WriteLine("Błędne dane!");
}
else
{

    Console.WriteLine("Wprowadź znak operacji:");
    string operation = Console.ReadLine();

    float result;

    switch (operation)
    {
        case "+":
            result = valueA + valueB;
            break;
        case "-":
            result = valueA - valueB;
            break;
        case "*":
            result = valueA * valueB;
            break;
        case "/":
            result = valueA / valueB;
            break;
        case "^":
            result = (float)Math.Pow(valueA, valueB);
            break;
        default:
            Console.WriteLine("Nieznana operacja!");
            return; //przerywa wykonywanie funkcji
    }

    Console.WriteLine($"{valueA} {operation} {valueB} = {result}");
}