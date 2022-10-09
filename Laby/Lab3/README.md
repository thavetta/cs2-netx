# Lab 3
## Geneické typy - použití
* Vytvořte v aplikaci kolekci celých čísel s využitím generických kolekcí List<T> a HashSet<T>. Naplňte je čísly od 1 do 1 000 000. Ověřte rychlost zjištění, zda kolekce obsahuje prvek 750 000 a časy porovnejte. Pro měření času použijte třídu Stopwatch.
* Vytvořte aplikaci, které předáte string a ona spočítá počet výskytů jednotlivých znaků. Po zpracování vypíše nejdřív setříděně znaky a jejich počet výskytů, a pak setříděně podle počtu výskytů jednotlivé znaky. Nealfanumerické znaky ignorujte. Pro zpracování dat využijte generické kolekce.
## Doporučený postup
  ### Rychlost
  1. Vytvořte consolovou aplikaci pro .NET
  1. Připravte instanci List<int> a HashSet<int> pro 1 000 000 prvků
  1. Nachystejte si instanci třídy Stopwatch (namespace System.Diagnostics)
  1. V cyklu for naplňte nejdřív List, pak HashSet a změřte každému typu čas plnění
  1. Udělejte alespoň 3x pokus o vyhledání hodnoty v kolekci List<int> pomocí metody IndexOf(). Pro každé hledání změřte čas. Hledejte čísla těsně u sebe.
  1. Udělejte 3x pokus o hledání v HashSetu pomocí funkce Contains(). Opět každému hledání změřte čas.
  1. Naměřené časy vypisujte nejlépe v jednotkách tics [ WriteLine(stopky.ElapsedTicks); ]
  1. Spusťte projekt v Release verzi pomocí Ctrl + F5 (proces mimo VS)
  1. Zamyslete se nad významem naměřených hodnot
  1. Poexperimentujte s hledaným číslem (menší než 1000, kolem 250 tisíc, 500 tisíc a těsně pod milion)
  1. Srovnejte chování času u List<int> a HashSet<int> pro různé hledané čísla.
  ### Počítač písmen
  1. Vytvořte consolovou aplikaci pro .NET 
  1. Nachystejte si nějaký testovací řetězec
  1. Naprogramujte metodu SpocitejVyskytPismen(string vstup), která vrátí kolekci typu SortedDictionary<char,int>.
     Metoda projde všechna písmenka vstupního řetězce, vyřadí nealfanumerické znaky (podívejte se na statické metody třídy Char) a do výsledné Dictionary dá jako klíč písmeno a k němu napočítá počet výskytů. Výsledné SortedDictionary je návratovou hodnotou. 
  1. Naprogramujte metodu Vypis, která obdrží jako parametr SortedDictionary a jeho obsah vypíše na obrazovku.
  1. Naprogramujte metodu UsporadejPodlePoctu, ktera dostane jako vstupni parametr SortedDictionary<char, int> a vrátí SortedDictionary<int, List<char>>.
Proiterujte vstupní Dictionary a naplňte nové SortedDictionary odpovídajícími položkami.
  1. Připravte metodu VypisDruhySeznam, která dostane jako parametr SortedDictionary<int, List<char>>. V této metodě vypište na řádek počet a k tomu písmena, která se v textu vyskytovala v daném počtu.
  1. Pokud Vám aplikace funguje, zkuste využít interface IEnumerable a typ KeyValuePair<K,V> jako parametr a návratový typ metod. Změnu proveďte tak, aby funkce pro hledání fungovaly s jakoukoliv kolekcí typu Dictionary. Změňte v metodách SortedDictionary na SortedList a ověřte, že aplikace bude stále fungovat.
