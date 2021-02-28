# Lab 5
## Aplikace pracující s třídou Osoba
* Třída Osoba v class library Osoby
* Třída bude mít tyto Property
    * ID => po vytvoření instance se nesmí měnit
    * Jméno, Příjmení, PlneJmeno
    * RokNarození => lze nastavit při vytvoření nebo metodou OpravRok
    * Plat typu int, ale umožňuje zadat i null
* Vytvořte aplikaci, která bude pracovat s kolekcí Osob
* Doplňte pomocí extensní metody do třídy Osoba metodu VratAktualniVek(). Spočítejte průměrný věk osob z kolekce.
## Doporučený postup
1. Vytvořte projekt Class Lib (.NET Core) s názvem Osoby. Solution nazvěte Lab5.
1. Projekt nastavte pro platformu .NET 5
1. Class1 přejmenujte na Osoba a nezapomeňte udělat třídu public
1. Vytvořte property třídy dle zadání. Kde se dá, využijte automatické property
1. Přidejte metodu OpravRok
1. Vytvořte konstruktor, který očekává rok jako povinný parametr
1. Vymyslete mechanizmus, aby první objekt Osoba v aplikaci dostal ID rovné 1, druhý 2, atd. Zamyslete se i nad všemi problémy, které by při přiřazení ID mohly v moderní aplikaci nastat.
1. Přidejte do Solution projekt PouzitiOsob typu ConsoleApp (.NET Core)
1. Projekt nastavte pro platformu .NET 5
1. V projektu vytvořte statickou třídu Utils a do ní udělejte statickou extenzní metodu VratAktualniVek, která pro osobu vrátí rozdíl mezi rokem narození a aktuálním rokem
1. Vytvořte v Program.cs metodu, která vrátí List<Osoba> s alespoň třemi osobami
1. Přidejte metodu, které předáte seznam osob a ona pomocí metody VratAktualniVek spočítá průměrný věk osob v kolekci (nepoužívejte LINQ!!!!)
1. Otestujte funkčnost aplikace
