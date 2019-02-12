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
        //entity dziala, jak to przeniesc do wcf??? wcf nie dziala
        //sprawdzanie w rejestracji czy login jest w bazie - DZIALA
        //cala akcja w rejestracji + bindowanie labeli nie dzialajace!!!!!!!!!!!!!!!
        //wątki przy otwieraniu konfiguratora i logowaniu się???
        //cos nie rabotajet, nie da sie w nowym watku otworzyc formularza bo musi byc otwierany z watku STA, (DISPATCHER)

        // w kosntruktorze zrobic getcpu w tasku
        // asynchroniczne metody z await

        // zmienic zeby pobieral do listy produkty z wcf uzywajac tego co na dole
        
        //WCF.ProduktyClient c = new WCF.ProduktyClient();
        //var ptest = c.GetProduktyAsync();

        // Service1.cs w produktyService metoda GetProdukty() poprawić zeby pobieral nazwe subcategorii i odpowiednie kolmuny, zrobic tak dla reszty

    }
}
