namespace Dominio
{
    public class Portata
    {
        protected string nome;
        protected bool disponibilita;
        protected double prezzo;

        private string codice;

        public Portata(string nome, bool disponibilita, double prezzo, string codice)
        {
            this.nome = nome;
            this.disponibilita = disponibilita;
            this.prezzo = prezzo;
            this.codice = codice;
        }

        public string GetNome()
        {
            return nome;
        }

        public bool GetDisponibilita()
        {
            return disponibilita;
        }
        public void SetDisponibilita(bool value)
        {
            disponibilita = value;
        }

        public double GetPrezzo()
        {
            return prezzo;
        }

        public string GetCodice()
        {
            return codice;
        }

        public override string ToString()
        {
            return $"Codice: {codice}\tNome: {nome}\t Prezzo: {prezzo}$";
        }
    }
}