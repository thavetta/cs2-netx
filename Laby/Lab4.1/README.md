# Lab 4.1
## Hrací kostky - callback
* Vytvořte knihovnu s třídou HraciKostka, se stavem Hodnota a metodou HodKostky, která Hodnotu změní
* HodKostky bude mít jako parametr delegáta na metodu s parametrem int
* Vytvořte aplikaci, která bude pracovat s třídou HraciKostka
* V ní vytvořte dvě různé třídy, které dokáží různým způsobem zobrazit hodnotu na kostce. Zobrazení zajistí metoda s jedním parametrem typu int.
* Uživatelské příkazy v aplikaci: 
h => hod, 1 => zobrazeni 1, 2 => zobrazeni 2, q => konec
## Doporučený postup
1. Vytvořte projekt typu Class Library s názvem Kostky
1. Zrušte třídu Class1 a vytvořte třídu HraciKostka s vlastnostmi Hodnota, MaxHodnota a metodou HodKostky dle zadání
1. Použijte generátor náhodných čísel (třída Random) pro simulaci hodu kostkou
1. Přidejte do solution projekt Console App .NET Core  s názvem Hra
1. Přidejte novému projektu referenci na knihovnu Kostky
1. V novém projektu vytvořte třídy ZobrazovacTextem a ZobrazovacZnakem pro různé způsoby zobrazení výsledku hodu kostkou
1. Ve třídách vytvořte nějakou metodu vracející void a s jedním parametrem int. Název metody dle fantazie
1. V program.cs vytvořte v Main instance obou zobrazovačů a kostky a vytvořte metodu pro otestování funkčnosti
1. Metodě předejte kostku a delegáty na metody pro zobrazení výsledku
1. Použijte Console.ReadKey() pro zjištění co uživatel programu stisknul na klávesnici
1. Otestujte korektní běh aplikace
