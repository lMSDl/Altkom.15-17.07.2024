using ConsoleApp;


Demos demos = new Demos();
//demos.Strings();
//demos.NumbersFormatting();
//demos.Numbers();
//demos.Arrays();

//Console.ReadLine();



Console.WriteLine("Podaj bok kwadratu:");
string input = Console.ReadLine();

//int side = int.Parse(input);
int side;
bool parseSuccess = int.TryParse(input, out side);

if (!parseSuccess)
{
    Console.WriteLine("Błędna wartość!");
}
else
{
    //if sprawdza warunek w nawiasie i jeśli jest on prawdziwy, to wykonuje się blok kodu pod nim
    if (side < 0)
    {
        Console.WriteLine("Nie mogę policzyć obwodu z ujemnego rozmiaru");
    }
    // jeśli poprzedni warunek nie jest spełniony, to sprawdzany jest kolejny if
    // else if - może występować wielokrotne
    else if (side > 0)
    {
        Console.WriteLine($"Kwadrat ma obwód {side * 4}");
    }
    //else - wykonuje blok kodu w każdym innym przypadku
    else /*if(side == 0)*/
    {
        Console.WriteLine("Kwadrat nie instnieje");
    }


    //jeżeli używany else, to tylko jeden blok kodu zostanie wykonany i sprawdzanie warunków zakończy się w przypadku wejścia w któryś z bloków
    //jeżeli nie używany else, to każdy if będzie traktowany osobno i warunek będzie sprzwdzany niezależnie
    //wniosek else jest też łącznikiem między kolejnymi if'ami

    if (side != 0)
    {
        Console.WriteLine("Bok jest różny od 0");
    }
    if(side == 0)
    {
        Console.WriteLine("Bok jest równy 0");
    }
}

bool result = side == 0; //== - porównanie
result = side != 0; //!= - nierówność
result = !(side == 0); // ! - zaprezeczenie wyrażenia logicznego
result = side < 0; // < - mniejsze
result = side > 0; // > - większe
result = side <= 0; // <= - mniejsze lub równe
result = side >= 0; // >= - większe lub równe

result = side < 0 || side == 0; // || - logiczne lub (OR)
result = side > 0 && side <= 10; // && - logiczne i (AND) 

