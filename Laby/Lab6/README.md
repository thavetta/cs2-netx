# Lab 6
## LINQ a Osoby
* Vložte do kolekce osob z labu 5 alespoň 6 osob
* Pomocí LINQ proveďte výpis:
  * Osob setříděných podle platu
  * Pouze osob narozených po roce 1980
  * Součet věků osob s platem nad 30.000 Kč
  * Vytvořte XML, které bude ze seznamu obsahovat pouze jméno, příjmení osob a id. Jméno a příjmení bude element, id attribut.
## Doporučený postup
1. Zkopírujte složku s projektem Lab 5 do složky Lab 6
1. Přejmenujte Solution file na Lab6.sln
1. Ve stávajícím programu předělejte výpočet průměrného věku na volání LINQ metod
1. Přidejte LINQ metody vracející požadované kolekce
1. Do třídy Osoba přidejte metodu ToString tak, aby vypsala celé jméno - rok narození - plat
1. Vytvořte metodu Vypis, které předáte jakoukoliv enumerovatelnou kolekci Osob a ona vypíše standardním ToString osobu v kolekci na obrazovku
1. Pro vytvoření XML použijte třídu XElement v kombinaci s LINQ výrazem
