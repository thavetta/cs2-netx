using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrazce;

/// <summary>
/// Abstraktní třída pro definici obecného obrazce
/// </summary>
public abstract class Obrazec : IKresleni
{
    private Bod poloha;

    /// <summary>
    /// Property definující polohu levého horního rohu oblasti zabírané obrazcem
    /// </summary>
    public Bod Poloha
    {
        get { return poloha; }
        set { poloha = value; }
    }

    private Barvy barva;

    /// <summary>
    /// Property definující barvu obrazce
    /// </summary>
    public Barvy Barva
    {
        get { return barva; }
        set
        {
            // kontrola, zda je hodnota v rozsahu enumu
            if (Enum.IsDefined(typeof(Barvy), value))
                barva = value;
            else
                throw new InvalidEnumArgumentException("Barva",(int) value, typeof(Barvy));
        }
    }

    private uint vyska;

    /// <summary>
    /// Výška prostoru který obrazec zabírá. Díky typu nelze zadat záporné číslo.
    /// </summary>
    public uint Vyska
    {
        get { return vyska; }
        set { vyska = value; }
    }

    private uint sirka;

    /// <summary>
    /// Šířka prostoru který obrazec zabírá. Díky typu nelze zadat záporné číslo.
    /// </summary>
    public uint Sirka
    {
        get { return sirka; }
        set { sirka = value; }
    }

    /// <summary>
    /// Metoda pro vykreslení obrazce, implementuje rozhraní IKresleni
    /// </summary>
    public void VykresliSe()
    {
        string typ = this.GetType().Name;
        Vypis(typ);
        VykresliSeInternal();
    }

    /// <summary>
    /// Interní metoda pro vykreslení obrazce, která je implementována v potomcích
    /// </summary>
    protected abstract void VykresliSeInternal();

    /// <summary>
    /// Interní metoda pro výpis informací o obrazci dle zadání v požadavcích na aplikaci
    /// </summary>
    /// <param name="typ"></param>
    protected void Vypis(string typ)
    {
        Console.WriteLine("Vykresluji obrazec {0} barvou {1} na pozici {2} o rozmerech {3} x {4}",typ,this.Barva,this.Poloha,this.Sirka,this.Vyska);
    }
}