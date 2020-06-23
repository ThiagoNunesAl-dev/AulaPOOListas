namespace AulaPOOLista
{
    public class Cartao
    {
        public string Titular { get; set; }
        public string Numero { get; set; }
        public string Bandeira { get; set; }
        protected int Cvv { get; set; }

        public Cartao () {

        }

        public Cartao (string _titular, string _numero, string _bandeira, int _cvv) {
            this.Titular = _titular;
            this.Numero = _numero;
            this.Bandeira = _bandeira;
            this.Cvv = _cvv;
        }
    }
}