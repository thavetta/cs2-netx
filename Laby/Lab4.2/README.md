# Lab 4.2
## Hod kostkou - události
* Upravte lab 4.1 tak, že:
  * HraciKostka bude mít event PoHoduKostkou
  * HraciKostka bude mít metodu HodKostkou bez parametru
  * Hlavní aplikace bude pro změnu zobrazení měnit zaregistrovanou metodu delegáta k události
## Doporučený postup
1. Zkopírujte složku se solution labu 4.1 do nové složky
1. Otevřete zkopírovanou solution a proveďte požadované úpravy
1. Do projektu Kostky přidejte třídu PoHoduKostkouEventArgs zděděnou z EventArgs s jednou propertou typu int 
1. Do typu HraciKostka přidejte událost PoHoduKostkou typu EventHandler<PoHoduKostkouEventArgs>
1. Do typu HraciKostka doplňte metody pro vyvolní události dle standardního paternu pro eventy
1. V projektu Hry upravte třídy pro zobrazení výsledku hodu. Doplňte do nich metody odpovídající .NET eventům pro ekci na událost PoHoduKostkou. Využijte už hotové metody,nekopírujte kód pro výpis výsledku hodu kostky.
1. Upravte metodu volanou z Main tak, aby používala jako parametr event handlery, které pak bude přiřazovat dle stisku klves do události PoHoduKostkou.
1. Otestujte, že vše opět stejně funguje
