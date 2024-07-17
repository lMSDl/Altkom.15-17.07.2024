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
        //pole klasy (field)
        //private - oznacza dostęp tylko dla elementów danej klasy (inne dostępne: public/internal/protected)
        //brak modyfikatora -> private
        //pola zazwyczaj są prywatne ze względu na hermetyzację, a dostęp realizowany jest przez metody dostępowe (getter i setter)
        private string name;

        //getter służy do pobrania wartości pola - metoda zwraca typ zgodny z typem pola
        //nazwa zwyczajowa składa się z Get + nazwa pola
        //string - metoda zwraca string
        public string GetName()
        {
            //instukcja zwracająca wynik działania metody - obowiązkowy gdy zadeklarowaliśmy, że klasa coś zwraca (jest inna niż void)
            return name;
        }

        //setter - do ustawiania wartości pola - metoda przyjmuje parametr, który zostaje wpisany w odpowiednie pole (można dodać kod "obróbki danych")
        //void - metoda nic nie zwaraca
        public void SetName(string value)
        {
            name = value.Trim();
        }

        //Property - właściwość

        //auto-property
        //właściwość integruje w sobie pole i metody dostępowe (getter i setter)
        //jest możliwość ograniczenia modyfikatora dostępu dla getter lub setter (osobno)
        public string LastName { /*private*/ get;  set; }

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
    }

}
