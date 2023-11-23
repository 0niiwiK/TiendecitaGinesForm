namespace TiendecitaGines
{
    using System.Runtime.Serialization.Formatters.Binary;

    internal static class Program
    {
        public static List<Bocadillo> lista_bocadillos { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>


        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
        public static string Init()
        {
            string ruta = ObtenerRuta("databank.data");

            return ruta;
        }

        public static string ObtenerRuta(string archivo)
        {
            return Path.Combine(Directory.GetCurrentDirectory(), archivo);

        }

        public static List<Bocadillo> CargarBocadillos(string ruta)
        {
            List<Bocadillo> bocadillos = new List<Bocadillo>();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(ruta, FileMode.Open);
            bocadillos = (List<Bocadillo>)bf.Deserialize(fs);
            fs.Close();
            return bocadillos;
        }

        public static void GuardarBocadillos(List<Bocadillo> lista, string ruta)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(ruta, FileMode.Create);
            bf.Serialize(fs, lista);
            fs.Flush();
            fs.Close();
        }

        [Serializable]
        public class Bocadillo
        {
            public string Nombre { get; set; }
            public int Stock { get; set; }
            public double Precio { get; set; }
            public char TipoPan { get; set; }
            public bool Calentito { get; set; }
            public byte[] Imagen { get; set; }

            public Bocadillo(string nombre, int stock, double precio, char tipoPan, bool calentito)
            {
                Nombre = nombre;
                Stock = stock;
                Precio = precio;
                TipoPan = tipoPan;
                Calentito = calentito;
            }

            public override string ToString()
            {
                return "Nombre: " + Nombre + " Stock: " + Stock + " Precio: " + Precio + " TipoPan: " + TipoPan + " Calentito: " + Calentito;
            }
        }
    }
}