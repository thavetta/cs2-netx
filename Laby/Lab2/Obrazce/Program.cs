using System.Collections.Generic;
using Obrazce;
using Obrazce.Tvary;

// Zápis vytvoření seznamu obrazců. Vytvoříme seznam obrazců a naplníme jej.
// Ukázka kódu bez použití zápisu třídy Program a metody Main

List<Obrazec> seznam = new List<Obrazec>
            {
                new Elipsa() {Barva = Barvy.Cervena, Poloha = new Bod() {X = 1, Y = 2}, Sirka = 100, Vyska = 50},
                new Ctverec() {Barva = Barvy.Bila, Poloha = new Bod(5,7), Sirka = 100, Vyska = 50},
                new Obdelnik() {Barva = Barvy.Modra, Poloha = new Bod(6,7), Sirka = 200, Vyska = 150},
                new Trojuhelnik() {Barva = Barvy.Hneda, Poloha = new Bod(3,9), Sirka = 100, Vyska = 100},
                new Elipsa() {Barva = Barvy.Zelena, Poloha = new Bod() {X = 5, Y = 7}, Sirka = 100, Vyska = 50}
            };

Vypis(seznam);

// Metoda pro vykreslení obrazců v libovolném typu kolekce či objektu,
// implementujícího rozhraní IEnumerable obsahujícího objekty implementující rozhraní IKresleni
// Kod této metody je nezávislý na konkrétních typech obrazců
void Vypis(IEnumerable<IKresleni> seznam)
{
    foreach (IKresleni obrazec in seznam)
    {
        obrazec.VykresliSe();
    }
}
