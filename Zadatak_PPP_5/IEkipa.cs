namespace Zadatak_PPP_5
{
    interface IEkipa
    {
        string ImeTrenera { get; set; }
        string Naziv { get; set; }

        float prosekGolovaPoIgracu();
        Fudaler vratiNajstarijeg();
    }
}