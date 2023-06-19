using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Paciente
    {
        //Declaramos las variables del paciente
        private int id;
        private string name;
        private string diagnosis;


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

        public string Diagnosis
        {
            get
            {
                return diagnosis;
            }
            set { diagnosis = value; }
        }

        //Constructor
        public Paciente(int id, string name, string diagnosis)
        {
            this.id = id;
            this.name = name;
            this.diagnosis = diagnosis;
        }

        //Metodo ToString
        public void Display()
        {
            Console.WriteLine($"Id Paciente: {id}");
            Console.WriteLine($"Nombre Paciente: {name}");
            Console.WriteLine($"Diagnosis Doctor: {diagnosis}");
        }
    }
}
