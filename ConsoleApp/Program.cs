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



Console.WriteLine("Napisz coś:");
string input = Console.ReadLine();

string[] words = input.Split();

//foreach zastępuje poniższy sposób iteracji po tablicy
for (int i = 0; i < words.Length; i++)
{
    string word = words[i];

    Console.WriteLine(word);
}


//foreach - pozwala przejsc po wszystkich elementach tablicy
foreach (string word in words)
{
    Console.WriteLine(word);
}

