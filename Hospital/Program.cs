using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hospital h = new Hospital();

            //Inicializamos nuestro objeto Medico con sus datos
            Medico m1 = new Medico ("Javi Gonzalez",23, "Ginecologo", 632789456,"javi@gmail.com",1);
            Medico m2= new Medico("Emily Mara", 43, "Ginecologo", 632789456, "mara@gmail.com", 2);

            //Inicializamos nuestro objeto Paciente con sus datos
            Paciente p1 = new Paciente(1, "Paco Gonzalez", "Fiebre");
            Paciente p2 = new Paciente(2, "Sara Gonzalez", "Covid");

            //Llamamos a los metodos de la clase hospital para añadir Doctor y paciente
            h.añadirDoctor(m1);
            h.añadirDoctor (m2);

            h.añadirPacientes(p1);
            h.añadirPacientes(p2);

            bool salir = false;
            //Menu
            while (!salir)
            {

                Console.WriteLine("1. Mostrar Doctores");
                Console.WriteLine("2. Mostrar Pacientes");
                Console.WriteLine("3. Eliminar Doctor");
                Console.WriteLine("4. Eliminar Paciente");
                Console.WriteLine("5. Asignar pacientes");
                Console.WriteLine("6. Salir");
                Console.WriteLine("Elige una de las opciones");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        h.MostrarDoctores();
                        Console.WriteLine();
                        break;

                    case 2:
                        h.MostrarPacientes();
                        Console.WriteLine();
                        break;

                    case 3:
                        EliminarDoctor(h);
                        Console.WriteLine();
                        break;

                    case 4:
                        EliminarPaciente(h);
                        Console.WriteLine();
                        break;
                    case 5:
                        h.AsignarPacientes();
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("Has elegido salir de la aplicación");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Elige una opcion entre 1 y 5");
                        break;
                }
                Console.ReadLine();
            }

        }

        //Metodo para preguntar al Admin que nos de la id del doctor llamando al metodo eliminar de la clase Hospital
        public static void EliminarDoctor(Hospital h)
        {
            Console.WriteLine("Dame el id del Doctor que quieres eliminar");
            int id = Convert.ToInt32(Console.ReadLine());
            h.EliminarDoctor(id);
        }

        //Metodo para preguntar al Admin que nos de la id del paciente llamando al metodo eliminar de la clase Hospital
        public static void EliminarPaciente(Hospital h)
        {
            Console.WriteLine("Dame el id del paciente que quieres eliminar");
            int id = Convert.ToInt32(Console.ReadLine());
            h.EliminarPaciente(id);
        }

    }
}
