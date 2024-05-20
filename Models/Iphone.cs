namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"

        public override void InstalarAplicativo(string nomeApp) 
        {
            if (nomeApp == "WhatsApp" && (Modelo == "Iphone15" || Modelo == "Iphone14"))
                Console.WriteLine($"O Aplicativo {nomeApp} foi instalado com sucesso no seu {Modelo}");
            else
                Console.WriteLine($"O Aplicativo {nomeApp} não é compativel com o modelo {Modelo}");
        }
    }
}