namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            if (nomeApp == "Rastreador" && Modelo == "Nokia14")
                Console.WriteLine($"O Aplicativo {nomeApp} foi instalado no seu {Modelo}");
            else
                Console.WriteLine($"O Aplicativo {nomeApp} não é compativel com o modelo {Modelo}");
        }
    }
}