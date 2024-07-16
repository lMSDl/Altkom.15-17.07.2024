using ConsoleApp;


Demos demos = new Demos();
//demos.Strings();
//demos.NumbersFormatting();
//demos.Numbers();
//demos.Arrays();
//demos.IfElse();

//Console.ReadLine();


bool stop = false;

//while - pętla która trwa gdy jej parametr jest true, parametr jest sprawdzany przed każdym wejściem do pętli
// jeśli przy pierwszym wejściu parametr będzie false, to pętla się nigdy nie wykona
while (!stop)
//while(true) //= pętla nieskończona
{
    Console.Clear();
    Console.WriteLine("1. Stringi; 2. Liczby; 3. Formatowanie");
    Console.WriteLine("Co chcesz zrobić?");
    string input = Console.ReadLine();

    switch(input)
    {
        case "1":
            demos.Strings();
            break;
        case "2":
            demos.Numbers();
            break;
        case "3":
            demos.NumbersFormatting();
            break;
        case "exit":

            stop = true;
            break;
        default:
            Console.WriteLine("Brak wskazanej opcji");
            break; //break wewnątrz switcha nie "propaguje" do while, więc nie przerywa pętli
    }

    //if (stop)
    //    break; //break przerywa pętlę
}


bool finish;

//do-while - sprawdza warunek po wykonaniu ciała - zapewnia, że zostanie ono wykonane co najmniej raz
//pozwala to wyeliminować inicjalizację zminnych przed wejściem do pętli
do
{
    Console.WriteLine("Co chcesz zrobić?");
    string operation = Console.ReadLine();
    switch (operation)
    {
        case "exit":
            finish = true;
            break;
        default:
            finish = false;
            Console.WriteLine(operation);
            break;
    }
} while (!finish);