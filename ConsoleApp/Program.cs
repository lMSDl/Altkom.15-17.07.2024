using ConsoleApp;


Demos demos = new Demos();
//demos.Strings();
//demos.NumbersFormatting();
//demos.Numbers();
//demos.Arrays();
//demos.IfElse();
//demos.WhileDoWhile();
//demos.For();

//Console.ReadLine();




Console.WriteLine("Podaj liczby rozdzielając je spacją:");
string input = Console.ReadLine();

List<int> ints = new List<int>();

foreach (var item in input.Split())
{
    ints.Add(int.Parse(item));
}



int accumulator = 0;
int counter = 0;
for (; counter < ints.Count; counter++)
{
    int value = ints[counter];
    if (value % 2 != 0)
        continue; //przerywa aktualną iterację i kontynuuje pętle (przechodzi do końca ciała)

    //accumulator = accumulator + ints[counter];
    accumulator += ints[counter];
    if (accumulator >= 100)
        break; //przerywa całą pętlę
}

Console.WriteLine($"Wykorzystano {counter + 1} wartości by osiągnąć wynik 100");

