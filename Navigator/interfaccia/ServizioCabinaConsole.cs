using Dominio;

namespace Interfaccia
{
    public class ServizioCabinaConsole
    {
        public void Start(NaviGator istanza)
        {
            Visualizza();
            IComando comando = Parser.GetInstance().GetComando(ElencoComandi.SERVIZIO_CABINA);

            while (!comando.GetCodiceComando().Equals("0"))
            {
                comando.Esegui(istanza);
                Console.WriteLine();
                Visualizza();
                comando = Parser.GetInstance().GetComando(ElencoComandi.SERVIZIO_CABINA);
            }
            comando.Esegui(istanza); // comando esci
        }

        public void Visualizza()
        {
            Console.WriteLine("***Menu servizio in cabina***");
            Console.WriteLine(ElencoComandi.ElencoTuttiComandi(ElencoComandi.SERVIZIO_CABINA));
            Console.WriteLine("FAI LA TUA SCELTA");
        }
    }
}