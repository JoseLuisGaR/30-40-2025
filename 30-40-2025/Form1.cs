using System.IO;
namespace _30_40_2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearFichero_Click(object sender, EventArgs e)
        {
            //StreamWrite es la clase que representa a un fichero de texto
            //en el que podemos escribir informacion.
            //EL fichero de texto lo creamos con el metodo(estatico) CreateText,
            //que pertenece a la clase File.
            //Para escrinir en el fichero, emplemos Write y WriteLine.
            //Close para cerrar el archivo, o podria quedar algun dato
            //sin guardar.
            StreamWriter fichero;
            fichero = File.CreateText("fichero1.txt");
            fichero.WriteLine("Hola este es mi primer fichero");
            fichero.Write("Siguiente Linea");
            fichero.WriteLine("\r\n");
            fichero.WriteLine("Adiossss");
            fichero.Close();
        }

        private void btnCrear2_Click(object sender, EventArgs e)
        {
            using (StreamWriter fichero = new StreamWriter("fichero1.txt"))
            {
                fichero.WriteLine("Este codigo es mas compacto");
            }
        }

        private void btnLeerArchivo1_Click(object sender, EventArgs e)
        {
            StreamReader fichero;
            string linea;
            fichero = File.OpenText("fichero1.txt");
            linea = fichero.ReadLine();
            Console.WriteLine(linea);
            fichero.Close();
        }

        private void bTNLeerArchivo2_Click(object sender, EventArgs e)
        {
            using(StreamReader fichero = File.OpenText("fichero1.txt"))
            {
                string linea;
                linea = fichero.ReadLine();
                Console.WriteLine(linea);
                Console.WriteLine(fichero.ReadLine());
                Console.WriteLine(fichero.ReadLine());
            }
        }

        private void btnLeerArchivo3_Click(object sender, EventArgs e)
        {
            StreamReader fichero;
            fichero = File.OpenText("fichero1.txt");
            while (!fichero.EndOfStream)
                Console.WriteLine(fichero.ReadLine());
            fichero.Close();
        }

        private void btnLeerArchivo4_Click(object sender, EventArgs e)
        {
            StreamReader fichero;
            string linea;
            fichero = File.OpenText("fichero1.txt");
            do
            {
                linea = fichero.ReadLine();
                if (linea != null)
                    Console.WriteLine(linea);
            }
            while (linea != null);
            fichero.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            StreamWriter fichero;
            fichero = File.CreateText("fichero2.txt");
            fichero.WriteLine("PrimeraPrueba");
            fichero.Close();

            fichero = File.AppendText("fichero2.txt");
            fichero.WriteLine("Segunda Prueba");
            fichero.Close();
        }
    }
}
