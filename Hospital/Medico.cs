using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Medico
    {
        //Declaramos las variables del paciente
        private string name;
        private int edad;
        private string especialidad;
        private int telefono;
        private string email;
        private int id;
        public List<Paciente> pacientes { get; set; }


        //Getters i setters
        public int Id
        {
            get
            {
                return id;
            }
            set { id = value; }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set { name = value; }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set { email = value; }
        }

        public string Especialidad
        {
            get
            {
                return especialidad;
            }
            set { especialidad = value; }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
            set { edad = value; }
        }

        public int Telefono
        {
            get
            {
                return telefono;
            }
            set { telefono = value; }
        }

        //Constructor
        public Medico(string name, int edad, string especialidad, int telefono, string email, int id)
        {
            this.name = name;
            this.edad = edad;
            this.especialidad = especialidad;
            this.telefono = telefono;
            this.email = email;
            this.id = id;
            pacientes = new List<Paciente>();
        }
        //Metodo ToString
        public void Display()
        {
            Console.WriteLine($"Id Doctor: {id}");
            Console.WriteLine($"Nombre Doctor: {name}");
            Console.WriteLine($"Edad Doctor: {edad}");
            Console.WriteLine($"Especialidad Doctor: {especialidad}");
            Console.WriteLine($"Telefono Doctor: {telefono}");
            Console.WriteLine($"Email Doctor: {email}");
            //Esta parte mostramos los datos del paciente asignado al doctor
            Console.WriteLine("Pacientes asignados");
            if(pacientes == null)
            {
                Console.WriteLine($"Doctor {name} no tiene asignados ningun paciente");
            }
            else
            {
                foreach (Paciente paciente in pacientes)
                {
                    Console.WriteLine($"Id del paciente:{paciente.Id}");
                    Console.WriteLine($"Nombre del paciente:{paciente.Name}");
                    Console.WriteLine($"Diagnosis del paciente:{paciente.Diagnosis}");
                    Console.WriteLine("-------------------");

                }
            }

        }

    }
}
