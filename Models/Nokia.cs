namespace DesafioPOO.Models
{
   
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string emei, int memoria) : base(numero, modelo, emei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Istalando o aplicativo {nomeApp} no Nokia");
        }
    }
}