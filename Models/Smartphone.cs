namespace DesafioPOO.Models
{
    /// <summary>
    /// Representa um smartphone genérico.
    /// </summary>
    public abstract class Smartphone
    {
        /// <summary>
        /// O número de telefone do smartphone.
        /// </summary>
        public string Numero { get; set; }
        /// <summary>
        /// O modelo do smartphone.
        /// </summary>
        public string Modelo { get; set; }
        /// <summary>
        /// O código IMEI do smartphone.
        /// </summary>
        public string IMEI { get; set; }
        /// <summary>
        /// A capacidade de memória do smartphone em gigabytes.
        /// </summary>
        public int Memoria { get; set; }

        /// <summary>
        /// Cria uma nova instância da classe <see cref="Smartphone"/>.
        /// </summary>
        /// <param name="numero">O número de telefone do smartphone.</param>
        /// <param name="modelo">O modelo do smartphone.</param>
        /// <param name="imei">O código IMEI do smartphone.</param>
        /// <param name="memoria">A capacidade de memória do smartphone em gigabytes.</param>
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        /// <summary>
        /// Liga o smartphone.
        /// </summary>
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        /// <summary>
        /// Recebe uma ligação no smartphone.
        /// </summary>
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        /// <summary>
        /// Instala um aplicativo no smartphone.
        /// </summary>
        /// <param name="nomeApp">O nome do aplicativo a ser instalado.</param>
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
