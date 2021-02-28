# Lab 7
## Osoby a C# 6
* Použijte using static System.Console
* Vytvořte třídu SeznamOsob, která bude zapouzdřovat kolekci Osob. Pro přidání osoby vytvořte metodu PridejOsobu(Osoba o)
* Zajistěte, aby fungovala inicializace seznamu osob pomocí inicializátoru
* Předělejte propertu PlneJmeno, aby využila nový zápis pro vytvoření řetězce

## Doporučený postup
1. Zkopírujte složku s projektem Lab6 do složky Lab7
1. Přejmenujte Solution file na Lab7.sln
1. V projektu Osoby přidejte public třídu SeznamOsob s privátním členským prvkem "seznam" typu List<Osoba>
1. Implementujte interface IEnumerable<Osoba> na třídě SeznamOsob tak, aby vracel enumerátor seznamu
1. Přidejte metodu PridejOsobu(Osoba o) která přidá osobu pouze, pokud už v kolekci není. tedy každá osoba může být v SeznamuOsob jen jednou.
1. V projektu PouzitíOsob upravte metodu VratSeznamOsob tak, že nebude vracet List<Osoba>, ale vrátí třídu SeznamOsob. Všimněte si, že při inicializaci inicializátorem VS ohlásí chybu, že SeznamOsob nemá metodu Add(Osoba o)
1. Doplňte do třídy Utils extenzní metodu Add třídě SeznamOsob tak, aby zavolala metodu PridejOsobu. Všimněte si, že po přidání této metody chyba z inicializace zmizí a aplikace jde spustit
1. Použijte using static System.Console a upravte volání metod třídy Console
