/*

Implementação sugerida por WhyEssEff's 
https://exercism.org/tracks/csharp/exercises/roman-numerals/solutions/WhyEssEff

*/

using System;

public static class RomanNumeralExtension
{
    private static string? RomanUnits(this char portion) {
        switch (portion) {
            case '1': return "I";
            case '2': return "II";
            case '3': return "III";
            case '4': return "IV";
            case '5': return "V";
            case '6': return "VI";
            case '7': return "VII";
            case '8': return "VIII";
            case '9': return "IX";
            case '0': 
            default: return null;
        }
    }

    private static string? RomanTens(this char portion) {
        switch (portion) {
            case '1': return "X";
            case '2': return "XX";
            case '3': return "XXX";
            case '4': return "XL";
            case '5': return "L";
            case '6': return "LX";
            case '7': return "LXX";
            case '8': return "LXXX";
            case '9': return "XC";
            case '0': 
            default: return null;
        }
    }

    private static string? RomanHundreds(this char portion) {
        switch (portion) {
            case '1': return "C";
            case '2': return "CC";
            case '3': return "CCC";
            case '4': return "CD";
            case '5': return "D";
            case '6': return "DC";
            case '7': return "DCC";
            case '8': return "DCCC";
            case '9': return "CM";
            case '0': 
            default: return null;
        }
    }
    
    private static string? RomanThousands(this char portion) {
        switch (portion) {
            case '1': return "M";
            case '2': return "MM";
            case '3': return "MMM";
            case '0': 
            default: return null;
        }
    }

    public static string ToRoman(this int value) {
        string roman = string.Empty;
        char[] comparator = value.ToString().ToCharArray();

        switch (comparator.Length) {
            case 1: roman += comparator[0].RomanUnits(); break;
            case 2: roman += comparator[0].RomanTens() + comparator[1].RomanUnits(); break;
            case 3: roman += comparator[0].RomanHundreds() + comparator[1].RomanTens() + comparator[2].RomanUnits(); break;
            case 4: roman += comparator[0].RomanThousands() + comparator[1].RomanHundreds() + comparator[2].RomanTens() + comparator[3].RomanUnits(); break;
            default: break;
        } return roman;
    }
}