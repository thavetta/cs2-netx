using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrazce;

/// <summary>
/// Struktura definující bod v rovině určený souřadnicí X a Y.
/// Souřadnice X a Y jsou jakákoliv celá čísla.
/// </summary>
public struct Bod
{
    /// <summary>
    /// Souřadnice X v rovině
    /// </summary>
    /// <remarks>Výjimečný případ, kde je vhodné použít public field a nedělat property.</remarks>
    public int X;

    /// <summary>
    /// Souřadnice Y v rovině
    /// </summary>
    /// <remarks>Výjimečný případ, kde je vhodné použít public field a nedělat property.</remarks>
    public int Y;

    /// <summary>
    /// Konstruktor definující oba body
    /// </summary>
    /// <remarks>Protože to je struct, kompilátor vždy vytvoří i defaultní konstruktor, který nastaví bod 0,0</remarks>
    public Bod(int x, int y)
    {
        X = x;
        Y = y;
    }

    /// <summary>
    /// Převede bod na řetězec dle předpisu daného zadáním
    /// </summary>
    /// <returns>String reprezentující bod</returns>
    /// <remarks>Ukázka využití skládání řetězce operátorem + => metodou Concat(s1,</remarks>
    public override string ToString()
    {
        return "[" + X + ";" + Y + "]";
    }
}