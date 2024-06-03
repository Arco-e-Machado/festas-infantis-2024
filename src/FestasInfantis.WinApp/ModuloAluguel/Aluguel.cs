namespace FestasInfantis.WinApp.ModuloAluguel
{
    internal class Aluguel
    {
        public string cliente { get; set; }
        public string tema { get; set; }
        public string festa { get; set; }
        public bool status { get; set; }
        public double porcntSaida { get; set; }
        public double porcntEntrada { get; set; }
        public DateTime DataPagemento { get; set; }
    }
}
