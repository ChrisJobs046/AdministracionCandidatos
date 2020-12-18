using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Proyecto_Final
{
    [Serializable]
    class Candidato
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Fecha_de_Nacimiento { get; set; }
        public string Tipo_de_sangre { get; set; }
        public string Partido { get; set; }
        public string Size_del_traje { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Persona_de_contacto { get; set; }
        public string Telefono_de_contacto { get; set; }

    }

    [Serializable]
    class Program
    {
        private static Candidato can = new Candidato();
        //private static Manejador_Actividades MnjAct = new Manejador_Actividades();
        
        static void Main(string[] args)
        {
            Menu();
            
            Console.ReadKey();
        }

        //Configuración y personalización al Programa
        static void Configuracion()
        {
            Console.Title = "Christopher Alexander demostrando:";
            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(1000);
        }


        static void AgregarCandidato()
        {
            Console.Clear();
            Console.WriteLine("Vamos a agregar el candidato: ");
            
            Console.Write("Digite la Cedula{0}: ");
            can.Cedula = Console.ReadLine();
            Console.Write("Digite el nombre{0}: ");
            can.Nombre = Console.ReadLine();
            Console.Write("Digite el apellido{0}: ");
            can.Apellido = Console.ReadLine();
            Console.Write("Digite la fecha de nacimiento{0}:");
            string n = Console.ReadLine().Trim();
            string[] m = n.Split('/');
            can.Fecha_de_Nacimiento = Console.ReadLine();
            Console.Write("Digite el tipo de sangre{0}: ");
            can.Tipo_de_sangre = Console.ReadLine();
            Console.Write("Digite el partido(S,M,L){0}: ");
            can.Partido = Console.ReadLine();
            Console.Write("Digite el size del traje(S,M,L){0}: ");
            can.Size_del_traje = Console.ReadLine();
            Console.Write("Digite el telefono{0}: ");
            can.Telefono = Console.ReadLine();
            Console.Write("Digite el celular{0}: ");
            can.Celular = Console.ReadLine();
            Console.Write("Digite el email{0}: ");
            can.Email = Console.ReadLine();
            Console.Write("Digite la direccion{0}: ");
            can.Direccion = Console.ReadLine();
            Console.Write("Digite la persona de contacto{0}: ");
            can.Persona_de_contacto = Console.ReadLine();
            Console.Write("Digite el telefono de contacto{0}: ");
            can.Telefono_de_contacto = Console.ReadLine();

            Console.WriteLine("Su candidato se ha guardado. Presione enter para continuar");
            Console.ReadKey();
            Program.Menu();

           
        }

        static void EliminarCandidato()
        {
           public void eliminarCandidato()
          {

            Console.Clear();
            if (lista.Count > 0)
            {

                Console.WriteLine("Estos son los candidatos agregados: ");
                Console.WriteLine("No. \t\t C�dula \t\t Nombre \t\t Apellido");
                int n = 1;
                foreach (Candidato can in lista)
                {
                Console.WriteLine("{0} \t\t {1} \t\t {2} \t\t {3}", n, can.Cedula, can.Nombre, can.Apellido);
                n++;
                }
                Console.Write("Ingrese el n�mero del candidato que desea borrar: ");
                int.TryParse(Console.ReadLine(), out num);
                if (num >= 0 && num <= lista.Count)
                {

                    lista.RemoveAt(num - 1);
                    Console.WriteLine("El candidato ha sido borrado con �xito.");
                }
                else
                {
                   Console.WriteLine("El n�mero ingresado est� fuera de los l�mites de los candidatos ingresados. Pulse ENTER para continuar...");
                }
                }
                else
                {
                   Console.WriteLine("Usted no tiene candidatos agregados. Pulse ENTER para continuar...");
                }
                 Console.ReadKey();
                } 
        }

        public void ModificarCandidato()
        {

        }


        private static void VerCandidatos()
        {
            
            Console.Clear();
            Console.WriteLine("Bienvenid@, Aqui estan todos los candidatos guardados: ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Cedula: ");
            Console.WriteLine("Nombre: ");
            Console.WriteLine("Apellido: ");
            Console.WriteLine("Fecha de Nacimiento: ");
            Console.WriteLine("Tipo de sangre: ");
            Console.WriteLine("Partido: ");
            Console.WriteLine("Size del traje: ");
            Console.WriteLine("Telefono: ");
            Console.WriteLine("Celular: ");
            Console.WriteLine("Email: ");
            Console.WriteLine("Direccion: ");
            Console.WriteLine("Persona de contacto: ");
            Console.WriteLine("Telefono de contacto: ");

            WebClient wc = new WebClient();
            string tmp = wc.DownloadString("http://www.adamix.net/api/itla/misDatos/20185858/9987");
            
            string[] datos = tmp.Split(Environment.NewLine.ToCharArray());

            Console.WriteLine("");
            Console.WriteLine("Estos son los Candidatos. Presione enter para continuar");
            Console.ReadKey();
            Program.Menu();

        }


        private static void Menu()
        {
            string archivo = "data.dat";
        if (File.Exists(archivo))
        {
            FileStream streamRead = new FileStream(archivo, FileMode.Open);
            BinaryFormatter formaterRead = new BinaryFormatter();
            mngCan = (ManejadorCandidato)(formaterRead.Deserialize(streamRead));
            streamRead.Close();
        }           
                       
            Console.Clear();
            Console.WriteLine("Proyecto Final");
            Console.WriteLine("1- Gestionar Candidato.(A)");
            Console.WriteLine("2- Gestionar Actividades.(B)");
            Console.WriteLine("3- Reportes.(C)");
            Console.WriteLine("4- Salir.(D)");
            Console.Write("Que quieres hacer: ");
            var tmp = Console.ReadLine();
            if (tmp == "1")
            {
                Program.Menu2();
                //Gestionar Candidato//
            }
            else if(tmp == "2"){
               //Gestionar Actividades//

            }
            else if(tmp == "3"){
               //Reportes//
               Program.Reportes();
            }
            else if(tmp == "4")
            {
               //Salir//
               Console.WriteLine("Adiossssss");
            }
            else 
            {       //Si no son ningunas de las anteriores
                Console.WriteLine("Amig@ debe elegir una opcion valida. Presione enter para continuar");
                Console.ReadKey();
                Program.Menu();
            }

        }

        private static void Menu2()
        {
            Console.Clear();
            Console.WriteLine("1-Agregar Candidato");
            Console.WriteLine("2-Ver Candidato");
            Console.WriteLine("3-Eliminar Candidato");
            Console.WriteLine("4-Modificar Candidato");
            Console.WriteLine("5- Salir");
            var tmp = Console.ReadLine();
            if (tmp == "1")
            {
                Program.AgregarCandidato();
                //Agregar Candidato//
            }
            else if(tmp == "2"){
               //Ver lista de Candidatos//
               VerCandidatos();

            }
            else if(tmp == "3"){
               //Modificar candidatos//
               
            }
            else if(tmp == "4"){
               //Modificar candidatos//
               
               
            }
            else if(tmp == "5"){
               //Salir//
               Program.Menu();

            }
           
        }

        private static void Reportes()

        {


            Console.Clear();
            Console.WriteLine("Usted se encuentra en ver Reportes.");
            Console.WriteLine("1-Ver Candidato");
            Console.WriteLine("2- Ver Actividades");
            Console.WriteLine("3-Listado de Candidatos con Signos Zodiacales");
            Console.WriteLine("4-Exportar Candidato");
            var tmp = Console.ReadLine();
               if (tmp == "1")
               {
                   //Ver lista de Candidatos//
                   VerCandidatos();
               }
               else if(tmp == "2"){
                   //ver Actividades
                   VerActividades();

                }
                else if(tmp == "3"){
                   //Candidatos con signos Zodiacales//

                }
                else if(tmp == "4"){
                   //Exportar Candidatos//
               
            }
        }

        private static void VerActividades()
        {
            Console.Clear();
            Console.WriteLine("Estas son las actividades agregadas: ");
            Console.WriteLine("No. \t\t Nombre \t\t Apellido \t\t Fecha \t\t Descripci�n \t\t Costo \t\t Lugar");
        }

        {

    Candidato can = new Candidato();
    private List<Candidato> list =new List<Candidato>();
    ManejadorCandidato mngCan = new ManejadorCandidato();
    

    //Ver Candidatos
    public void ReportarCandidatos(List<Candidato> lista)
    {
        list = lista;
        Console.Clear();
        Console.WriteLine("Estos son los candidatos agregados: ");
        Console.WriteLine("No. \t\t Cedula \t\t Nombre \t\t Apellido \t\t Nacimiento \t\t Tipo de Sangre \t\t Partido");
        int n = 1;
        foreach (Candidato c in list)
        {
            Console.WriteLine("{0} \t\t {1} \t\t {2} \t\t {3} \t\t {4: dd/MM/yyyy} \t\t {5} \t\t {6}", n, c.Cedula, c.Nombre, c.Apellido, c.Nacimiento, c.tipoSangre, c.Partido);
            n++;
        }
        Console.ReadKey();
    }

    //Ver actividades
    public void ReportarActividades(List<Candidato> lista)
    {
        list = lista;
        Console.Clear();
        Console.WriteLine("Estas son las actividades agregadas: ");
        Console.WriteLine("No. \t\t Nombre \t\t Apellido \t\t Fecha \t\t Descripcion \t\t Costo \t\t Lugar");
        int n = 1;
        foreach (Candidato c in list)
        {
            Console.WriteLine("{0} \t\t {1} \t\t {2} \t\t {3} \t\t {4: dd/MM/yyyy} \t\t {5} \t\t {6}", n, c.Nombre, c.Apellido, c.fecha[0], c.desc[0], c.costo[0], c.lugar[0]);
            n++;
        }
        Console.ReadKey();
    }


}



    }
}



