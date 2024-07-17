//namespace - przestrzeń nazw, czyli adres pod którym "mieszka" klasa
//namespace zaciągamy używając "using"
namespace Models/*;*/ //namespace może być ograniczony za pomocą klamerek lub stosując ";" oznaczamy, że ma zastosowanie dla całego pliku
{

    //pełna nazwa klasy to <namespace>.<nazwa>
    // <modyfikator dostępu> class <nazwaKlasy>

    //public - modyfikator dostępu - oznacza, że z klasy można korzystać wszędzie
    //internal - modyfikator dostępu - oznacza, że z klasy można korzystać tylko w projekcie "rodzimym"
    //brak modyfikatora dosępu oznacza zastosowanie modyfikatora o najwyższym poziomie ochrony (w przypadku klasy to internal)

    //class - szablon opisujący zachowania/metody i cechy/stany obiektów (instancji klas), które są wytwarzane na jej podstawie
    public class Person
    {
        //metoda konstrukcyjna  (konstruktor) - bezparametrowy
        //brak określenia typu zwracanego i nazwa taka sama jak nazwa klasy
        //metody konstrukcyjne są potrzebne, aby wstępnie skonfigurować obiekt
        //jeśli klasa NIE MA ŻADNEGO zdefiniowanego konstruktora, to konstruktor bezparametrowy jest generowany automatycznie
        public Person()
        {
            _name = "brak";
        }

        //konstruktor parametrowy - służy do zapewnienia klasie wartości początkowych przekazanych jako parametry
        //jeśli w klasie występuje jakiś konstuktor parametrowy, to konstuktor bezparametrowy nie zostanie automatycznie wygenerowany
        //chcąc posiadać jednocześnie konstruktor parametrowy i bezparametrowy musimy go jawnie utworzyć
        public Person(string name)
        {
            _name = name;
        }

        //konstruktor teleskopowy - rozszeża możliwości innego konstruktora, przekazują do niego część parametrów przez "this"
        public Person(string name, string lastName, int age) : this(name)
        {
            LastName = lastName;
            Age = age;
        }


        //pole klasy (field)
        //private - oznacza dostęp tylko dla elementów danej klasy (inne dostępne: public/internal/protected)
        //brak modyfikatora -> private
        //pola zazwyczaj są prywatne ze względu na hermetyzację, a dostęp realizowany jest przez metody dostępowe (getter i setter)
        private string _name;

        //getter służy do pobrania wartości pola - metoda zwraca typ zgodny z typem pola
        //nazwa zwyczajowa składa się z Get + nazwa pola
        //string - metoda zwraca string
        public string GetName()
        {
            //instukcja zwracająca wynik działania metody - obowiązkowy gdy zadeklarowaliśmy, że klasa coś zwraca (jest inna niż void)
            return _name;
        }

        //setter - do ustawiania wartości pola - metoda przyjmuje parametr, który zostaje wpisany w odpowiednie pole (można dodać kod "obróbki danych")
        //void - metoda nic nie zwaraca
        public void SetName(string value)
        {
            _name = value.Trim();
        }

        //Property - właściwość

        //auto-property
        //właściwość integruje w sobie pole i metody dostępowe (getter i setter)
        //jest możliwość ograniczenia modyfikatora dostępu dla getter lub setter (osobno)
        public string LastName { /*private*/ get; set; }

        //backfield do full-property - pozwala na dodatkowy kod w setterze i getterze
        private int age;
        //full-property
        public int Age
        {
            //getter dla property
            get
            {
                return age;
            }
            //setter dla property - posiada niejawny parametr o nazwie value
            set
            {
                age = value;
            }
        }

        //<modyfikator dostępu> <typ zwracany> <nazwa metody>()
        public string GenerateBio()
        {
            string bio = $"{_name} {LastName}, wiek {Age} lat";
            return bio;
        }

        public void ChangeNamesToTitleCase()
        {
            //_name = $"{_name.ToUpper()[0]}{_name.Substring(1).ToLower()}";
            //LastName = $"{LastName.ToUpper()[0]}{LastName.Substring(1).ToLower()}";
            _name = ToTitleCase(_name);
            LastName = ToTitleCase(LastName);
        }

        //prywatna metoda pomocnicza powstała by uniknąć powtarzającego się kodu 
        private string ToTitleCase(string input)
        {
            return input[0].ToString().ToUpper() + input.Substring(1).ToLower();
        }
    }

}
