using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_PPP_5
{
    class Fudaler : IFudbaler
    {
        public Fudaler(string ime, string prezime, int brojGolova, int brojDresa, int godine, string pozicija)
        {
            Ime = ime;
            Prezime = prezime;
            BrojGolova = brojGolova;
            BrojDresa = brojDresa;
            Godine = godine;
            Pozicija = pozicija;
        }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int BrojGolova { get; set; }
        public int BrojDresa { get; set; }
        public int Godine { get; set; }
        public string Pozicija { get; set; }


        public void DajGol()
        {
            BrojGolova++;
        }

        public float RacunajProsekGolova(int brojUtakamica)
        {
            return (float)BrojGolova / brojUtakamica;
        }
    }
}
