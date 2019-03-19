using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSklep.ViewModel
{
    class TODO
    {
        //co jest do zrobienia

       //SZCZEGOLY PRODUKTU
        ///////////////////////////
        // dodany nowy window z detailsami produktu, zrobic zeby tam wrzucało xmla sformatowanego dla kazdego produktu, czyli:
        //      DONE dodac viewmodel dla windowsa, podbindowac text z textblocka, dodac formatowanie xmla,
        //      DONE ustawic, podbindowac przyciski na konfiguratorze do viewmodelu
        //      DONE zbindowany jest tylko dtagrid cpu, zrobic reszte
        ////////////////////////////////
       ///KOSZYK
        ///////////////////////////
        //KOSSZYK ZROBIC I PODBINDOWAC PRZYCISKU
        //JAK MIEC DOSTEP DO KOSZYKA? PRZEKAZYWAC W KONSTRUKTORZE CZY KLASA STATYCZNA?
        //-> koszyk jako tabele w bazie, przy dodawaniu do koszyka dodajesz produkty do tabeli, ustawiasz na status acive czy cos podobnego, przy usunieciu koszyka ustawiasz status na inactive
        //      DONE dodac statusy słownikowe do tabeli Basketcode 
        /////////////////////////////
       ///WĄTKI
        /////////////////////////////
        //wątki przy otwieraniu konfiguratora i logowaniu się???
        //cos nie rabotajet, nie da sie w nowym watku otworzyc formularza bo musi byc otwierany z watku STA, (DISPATCHER)
        // w kosntruktorze zrobic getcpu w tasku
        // asynchroniczne metody z await
        // Service1.cs w produktyService metoda GetProdukty() poprawić zeby pobieral nazwe subcategorii i odpowiednie kolmuny, zrobic tak dla reszty

      ///BINDOWANIE LABELI
        ////////////////////////
        // napisac swoj wlasny konwertere booleantovisibility z hidden i collapsed

   ///LOGOWANIE DO SKLEPU
        ////////////////
        /// usuwać buttona zaloguj sie/zmieniac na wyloguj + usuwanie zarejestruj sie
    }
}
