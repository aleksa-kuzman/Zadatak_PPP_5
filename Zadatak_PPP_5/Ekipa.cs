using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_PPP_5
{
    class Ekipa : IEkipa
    {
        public Ekipa(string naziv, IList<Fudaler> igraci, string imeTrenera)
        {
            Naziv = naziv;
            Igraci = new List<Fudaler>();
            ImeTrenera = imeTrenera;
        }

        public string Naziv { get; set; }
        IList<Fudaler> Igraci { get; set; }
        public string ImeTrenera { get; set; }

        public Fudaler vratiNajstarijeg()
        {
            var najstarijiIgrac = Igraci[0];
            for (int i = 1; i < Igraci.Count; i++)
            {
                if (Igraci[i].Godine > najstarijiIgrac.Godine)
                    najstarijiIgrac = Igraci[i];
            }

            return najstarijiIgrac;
        }

        public float prosekGolovaPoIgracu()
        {
            var ukupnoGolova = 0;
            for (int i = 0; i < Igraci.Count; i++)
            {
                ukupnoGolova += Igraci[i].BrojGolova;
            }

            return ukupnoGolova / Igraci.Count;
        }

    }
}
