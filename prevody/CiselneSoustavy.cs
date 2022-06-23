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
            string hex = "";

            while (delka % 4 != 0)
                {
                    bin = bin.Insert(0, "0") ;
                    delka++;
                }

            /*StringBuilder hexadecimal = new StringBuilder();
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
                
            }*/
            while (delka > 0)
            {
                string substring = bin.Substring(bin.Length - 4, 4);
                bin = bin.Remove(bin.Length - 4, 4);
                delka -= 4;

                switch (substring)
                {
                    case "0000": hex = hex.Insert(0, "0"); break;
                    case "0001": hex = hex.Insert(0, "1"); break;
                    case "0010": hex = hex.Insert(0, "2"); break;
                    case "0011": hex = hex.Insert(0, "3"); break;
                    case "0100": hex = hex.Insert(0, "4"); break;
                    case "0101": hex = hex.Insert(0, "5"); break;
                    case "0110": hex = hex.Insert(0, "6"); break;
                    case "0111": hex = hex.Insert(0, "7"); break;
                    case "1000": hex = hex.Insert(0, "8"); break;
                    case "1001": hex = hex.Insert(0, "9"); break;
                    case "1010": hex = hex.Insert(0, "A"); break;
                    case "1011": hex = hex.Insert(0, "B"); break;
                    case "1100": hex = hex.Insert(0, "C"); break;
                    case "1101": hex = hex.Insert(0, "D"); break;
                    case "1110": hex = hex.Insert(0, "E"); break;
                    case "1111": hex = hex.Insert(0, "F"); break;
                    default:
                        return "Spatne cislo";
                }
            }

            return hex.ToString();

        }

        public string HexToBin(string hexdec)
        {

            string bin = string.Empty;
            int delka = hexdec.Length - 1;
            for (int i = 0; i <= delka; i++)
            { 
                switch (hexdec[i])
                {
                    case '0':
                        bin = bin.Insert(bin.Length,"0000");
                        break;
                    case '1':
                        bin = bin.Insert(bin.Length, "0001");
                        break;
                    case '2':
                        bin = bin.Insert(bin.Length, "0010");
                        break;
                    case '3':
                        bin = bin.Insert(bin.Length, "0011");
                        break;
                    case '4':
                        bin = bin.Insert(bin.Length, "0100");
                        break;
                    case '5':
                        bin = bin.Insert(bin.Length, "0101");
                        break;
                    case '6':
                        bin = bin.Insert(bin.Length, "0110");
                        break;
                    case '7':
                        bin = bin.Insert(bin.Length, "0111");
                        break;
                    case '8':
                        bin = bin.Insert(bin.Length, "1000");
                        break;
                    case '9':
                        bin = bin.Insert(bin.Length, "1001");
                        break;
                    case 'A':
                    case 'a':
                        bin = bin.Insert(bin.Length, "1010");
                        break;
                    case 'B':
                    case 'b':
                        bin = bin.Insert(bin.Length, "1011");
                        break;
                    case 'C':
                    case 'c':
                        bin = bin.Insert(bin.Length, "1100");
                        break;
                    case 'D':
                    case 'd':
                        bin = bin.Insert(bin.Length, "1101");
                        break;
                    case 'E':
                    case 'e':
                        bin = bin.Insert(bin.Length, "1110");
                        break;
                    case 'F':
                    case 'f':
                        bin = bin.Insert(bin.Length, "1111");
                        break;
                    default:
                        return "\nŠpatné hexadecimální číslo";
                }
             
            }
            return bin;
        }
    }

    }
    

