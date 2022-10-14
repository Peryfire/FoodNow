namespace FoodNow.Model
{
    public class Sweet
    {
        private string _nome = string.Empty;
        private string _descrizione = string.Empty;
        private double _prezzo = double.MinValue;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }

        public double Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }

        public Sweet(string nome, string descrizione, double prezzo)
        {
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
        }
    }
}
