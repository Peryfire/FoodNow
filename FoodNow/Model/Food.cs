using SQLite;

namespace FoodNow.Model
{
    public class Food
    {
        [PrimaryKey]
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string Tipo { get; set; }
        public string Immagine { get; set; }
        public double Prezzo { get; set; }

        //private string _nome;
        //private string _descrizione;
        //private string _tipo;
        //private double _prezzo;

        //public string Nome
        //{
        //    get { return _nome; }
        //    set { _nome = value; }
        //}

        //public string Descrizione
        //{
        //    get { return _descrizione; }
        //    set { _descrizione = value; }
        //}

        //public string Tipo
        //{
        //    get { return _tipo; }
        //    set { _tipo = value; }
        //}

        //public double Prezzo
        //{
        //    get { return _prezzo; }
        //    set { _prezzo = value; }
        //}

        //public Food(string nome, string descrizione,string tipo, double prezzo)
        //{
        //    Nome = nome;
        //    Descrizione = descrizione;
        //    Tipo = tipo;
        //    Prezzo = prezzo
        //}
    }
}
