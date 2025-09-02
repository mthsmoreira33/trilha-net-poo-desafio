namespace DesafioPOO.Models
{
    /// <summary>
    /// Representa um smartphone da marca Apple (iPhone).
    /// </summary>
    public class Iphone : Smartphone
    {
        /// <summary>
        /// Cria uma nova instância da classe <see cref="Iphone"/>.
        /// </summary>
        /// <param name="numero">O número de telefone do smartphone.</param>
        /// <param name="modelo">O modelo do smartphone.</param>
        /// <param name="imei">O código IMEI do smartphone.</param>
        /// <param name="memoria">A capacidade de memória do smartphone em gigabytes.</param>
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        /// <summary>
        /// Instala um aplicativo no iPhone.
        /// </summary>
        /// <param name="nomeApp">O nome do aplicativo a ser instalado.</param>
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no iPhone via App Store.");
        }
    }
}