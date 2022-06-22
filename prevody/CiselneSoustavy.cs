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
            if (dec < 1) return "0";

            int hexCis = dec;
            char znakCifry = 'A';
            string hexStr = string.Empty;


            while (dec > 0)
            {
                hexCis = dec % 16;

                if (hexCis < 10)
                    hexStr = hexStr.Insert(0, Convert.ToChar(hexCis + 48).ToString());
                else
                    hexStr = hexStr.Insert(0, Convert.ToChar(hexCis + 55).ToString());

                dec /= 16;
            }

            while(dec != 0)
            {
                int zb = dec % 16;
                if(zb<=0)
                {
                    hexCis = zb + hexCis;
                }
                else
                {
                    znakCifry = (char)('A' + zb - 10);
                    hexCis = znakCifry + hexCis;
                }
            }

            return hexStr;

        }

        public string BinToHex(int bin)
        {
            int  dec = 0, i = 1, zbytek;
            int hexCis = dec;
            string hexStr = string.Empty;


            while (bin != 0)
            {
                zbytek = bin % 10;
                dec = dec + zbytek * i;
                i = i * 2;
                bin = bin / 10;
            }

            while (dec > 0)
            {
                hexCis = dec % 16;

                if (hexCis < 10)
                    hexStr = hexStr.Insert(0, Convert.ToChar(hexCis + 48).ToString());
                else
                    hexStr = hexStr.Insert(0, Convert.ToChar(hexCis + 55).ToString());

                dec /= 16;
            }

            return hexStr;

        }

    }
}
