using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prevody
{
    class CiselneSoustavy
    {
        public string BinToDec(int binCis)
        {
            double vysledek = 0;
            for (int i = 0; binCis > 0; i++)
            {
                int cislo = binCis % 10;
                if (cislo == 1)
                {
                    vysledek += Math.Pow(2, i);
                }
                binCis /= 10;
            }
            return vysledek.ToString();
        }

        public string DecToBin(int dec)
        {
            string vysledek = string.Empty;
            while (dec > 0)
            {
                int zbytek = dec % 2;
                dec /= 2;
                vysledek = zbytek + vysledek;
            }


            return vysledek;
        }

        public string HexToDecimal(string hexCis)
        {
            int delka = hexCis.Length;
            int zaklad = 1;
            int decCis = 0;


            for (int i = delka - 1; i >= 0; i--)
            {
                if (hexCis[i] >= '0' && hexCis[i] <= '9')
                {
                    decCis += (hexCis[i] - 48) * zaklad;
                    zaklad = zaklad * 16;
                }
                else if (hexCis[i] >= 'A' && hexCis[i] <= 'F')
                {
                    decCis += (hexCis[i] - 55) * zaklad;
                    zaklad = zaklad * 16;
                }
            }
            return decCis.ToString();
        }

        public string DecToHex(int dec)
        {
            string hex = "";
            int zbytek = 0;
            while (dec > 0)
            {
                zbytek = dec % 16;
                if (zbytek >= 0 && zbytek <= 9)
                {
                    hex = hex.Insert(0, zbytek.ToString());
                }
                else
                {
                    char znakCifry = (char)('A' + zbytek - 10);
                    hex = hex.Insert(0, znakCifry.ToString());

                }

                dec /= 16;
            }
            return hex;

        }

        public string BinToHex(string bin)
        {
            int delka = bin.Length;
            string hex = string.Empty;
           
                while(delka % 4 != 0)
                {
                    bin = bin.Insert(0, "0") ;
                    delka++;
                }

            StringBuilder hexadecimal = new StringBuilder();
            StringBuilder cast = new StringBuilder("0000");
            for (int i = 0; i < bin.Length; i += 4)
            {
                for (int j = i; j < i + 4; j++)
                {
                    cast[j % 4] = bin[j];
                }          

                switch (cast.ToString())
                {
                    case "0000": hexadecimal.Append('0'); break;
                    case "0001": hexadecimal.Append('1'); break;
                    case "0010": hexadecimal.Append('2'); break;
                    case "0011": hexadecimal.Append('3'); break;
                    case "0100": hexadecimal.Append('4'); break;
                    case "0101": hexadecimal.Append('5'); break;
                    case "0110": hexadecimal.Append('6'); break;
                    case "0111": hexadecimal.Append('7'); break;
                    case "1000": hexadecimal.Append('8'); break;
                    case "1001": hexadecimal.Append('9'); break;
                    case "1010": hexadecimal.Append('A'); break;
                    case "1011": hexadecimal.Append('B'); break;
                    case "1100": hexadecimal.Append('C'); break;
                    case "1101": hexadecimal.Append('D'); break;
                    case "1110": hexadecimal.Append('E'); break;
                    case "1111": hexadecimal.Append('F'); break;
                    default:
                        return "Špatné číslo";
                }
                
            }

            return hexadecimal.ToString();

        }

        public string HexToBin(string hexCis)
        {
            string dec = HexToDecimal(hexCis).ToString();
            string bin = DecToBin(int.Parse(dec));
            return bin;
        }

    }
    }

