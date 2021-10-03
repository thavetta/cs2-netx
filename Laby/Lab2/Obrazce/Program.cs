using System.Collections.Generic;
using Obrazce;
using Obrazce.Tvary;

List<Obrazec> seznam = new List<Obrazec>
            {
                new Elipsa() {Barva = Barvy.Cervena, Poloha = new Bod() {X = 1, Y = 2}, Sirka = 100, Vyska = 50},
                new Ctverec() {Barva = Barvy.Bila, Poloha = new Bod() {X = 5, Y = 7}, Sirka = 100, Vyska = 50},
                new Obdelnik() {Barva = Barvy.Modra, Poloha = new Bod() {X = 6, Y = 7}, Sirka = 100, Vyska = 50},
                new Trojuhelnik() {Barva = Barvy.Hneda, Poloha = new Bod() {X = 3, Y = 7}, Sirka = 100, Vyska = 50},
                new Elipsa() {Barva = Barvy.Zelena, Poloha = new Bod() {X = 5, Y = 7}, Sirka = 100, Vyska = 50}
            };

Vypis(seznam);

void Vypis(IEnumerable<IKresleni> seznam)
{
    foreach (IKresleni obrazec in seznam)
    {
        obrazec.VykresliSe();
    }
}
