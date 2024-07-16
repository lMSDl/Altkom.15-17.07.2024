using ConsoleApp;


Demos demos = new Demos();
//demos.Strings();
//demos.NumbersFormatting();
//demos.Numbers();
//demos.Arrays();
//demos.IfElse();
//demos.WhileDoWhile();

//Console.ReadLine();

//I - inicjalizacja pętli - wykonuje się tylko raz na początku
//II - warunek kontynukacji pętli - wykonuje się przed każdym wykonaniem ciała
//III - ciało pętli
//IV - akcja po wykonaniu ciała - najczęściej inkrementacja licznika

//for(I; II; IV )
//   { III; }

for(int i = 0; i < 5; i++ /*i = i + 1*/)
{
    Console.WriteLine(i);
}


//pętla nieskończona - odpowiednik while(true)
/*for (; ; )
{
    Console.WriteLine("*");
}*/

Console.WriteLine("---");


int value = 5;
for(; value > 0; value--)
{
    Console.WriteLine(  value );
}

Console.WriteLine("---");

value = 0;
for (; value < 5;)
{
    Console.WriteLine(++value);
}

Console.WriteLine("---");

value = 0;
for (; value < 5;)
{
    Console.WriteLine(value++);
}

string input = Console.ReadLine();
string[] splittedInput = input.Split();

for (int i = 0; i < splittedInput.Length; i++)
{
    Console.WriteLine(splittedInput[i]);
}
