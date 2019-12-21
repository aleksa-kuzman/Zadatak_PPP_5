using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_PPP_5
{
    class Fudaler : IFudbaler
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int BrojGolova { get; set; }
        public int BrojDresa { get; set; }

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
