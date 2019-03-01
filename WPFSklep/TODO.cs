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
        //NIE DZIALA BINDOWANIE LABELI ERROROWYCH NIE WIEM CZMEU BO JUZ DZIAŁAŁO JPRDL
        //cala akcja w rejestracji + bindowanie labeli nie dzialajace!!!!!!!!!!!!!!!

        ///////////////////////////
        // dodany nowy window z detailsami produktu, zrobic zeby tam wrzucało xmla sformatowanego dla kazdego produktu, czyli:
        //      DONE dodac viewmodel dla windowsa, podbindowac text z textblocka, dodac formatowanie xmla,
        //      DONEustawic, podbindowac przyciski na konfiguratorze do viewmodelu
        //      DONE zbindowany jest tylko dtagrid cpu, zrobic reszte
        //KOSSZYK ZROBIC I PODBINDOWAC PRZYCISKU
        //JAK MIEC DOSTEP DO KOSZYKA? PRZEKAZYWAC W KONSTRUKTORZE CZY KLASA STATYCZNA?

        /////////////////////////////
        ///
        //wątki przy otwieraniu konfiguratora i logowaniu się???
        //cos nie rabotajet, nie da sie w nowym watku otworzyc formularza bo musi byc otwierany z watku STA, (DISPATCHER)

        // w kosntruktorze zrobic getcpu w tasku
        // asynchroniczne metody z await

        // Service1.cs w produktyService metoda GetProdukty() poprawić zeby pobieral nazwe subcategorii i odpowiednie kolmuny, zrobic tak dla reszty

    }
}
