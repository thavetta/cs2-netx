# Lab 2
## Aplikace obrazce 1.0
* Aplikace umožňuje vykreslovat obrazce (čtverec, kruh, obdélník, elipsa, rovnoramenný trojúhelník).
* Každý obrazec má barvu, kterou se vykreslí, definici levého horního rohu, výšku a šířku.
* Každý obrazec má metodu VykresliSe(), která na konzoli vypíše text „Vykresluji obrazec xxxx barvou yyyyy na pozici [A,B] o rozměrech X x Y." 
Metodu předepište pomocí interface IKresleni.
* Aplikace bude udržovat pole obrazců a bude obsahovat metodu, ve které dojde k vykreslení všech obrazců.

## Doporučení k postupu
1. Konzolová aplikace pro .NET 
1. Vytvořte pomocnou strukturu Bod (souřadnice X a Y a metoda pro výpis ToString()) a enum Barvy s výčtem několika základních barev.
1. Abstraktní třída Obrazec, která bude implementovat IKresleni a bude obsahovat vlastnosti pro barvu, pozici, šířku a výšku.
1. Konkétní typy obrazců budou řešit pouze to čím se vzájemně liší. Pro přehlednost projektu je umístěte do samostatné složky Tvary a použijte korektně namespace.
1. V Program.cs vytvořte kolekci obrazců a vytvořte metodu pro zavolání metody VykresliSe() s využitím co nejgeneričtějího interface.
