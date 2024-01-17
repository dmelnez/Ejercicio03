class Program
{
    /// <summary>
    /// Clase principal de la aplicacion, por la cual esta se ejecutara
    /// <author>DMN - 17-01-2024</author>
    /// </summary>
    /// <param name="args"></param>
    /// 
    static void Main(string[] args)
    {
        /// <summary>
        /// Metodo por el cual la aplicacion se lanzara
        /// <author>DMN - 17-01-2024</author>
        /// </summary>
        /// <param name="args"></param>


        Console.WriteLine("Introduce el peso del Sacos");
        int pesoSaco = Convert.ToInt32(Console.ReadLine());


        long pesoFurgoneta = 4000;

        long numesoDeSacos = pesoFurgoneta / pesoSaco;

        Console.WriteLine("La furgoneta puede cargar: " + numesoDeSacos + " Sacos");

      

    }


}