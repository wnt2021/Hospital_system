using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Hospital
    {
        private List<Medico> doctores;
        private List<Paciente> pacientes;

        public Hospital()
        {
            doctores = new List<Medico>();
            pacientes = new List<Paciente>();
        }

        //Metodo para añadir un nuevo doctor
        public void añadirDoctor(Medico doctor)
        {
            doctores.Add(doctor);
        }

        //Metodo para añadir nuevo paciente
        public void añadirPacientes(Paciente paciente) 
        {

            pacientes.Add(paciente);
        }

        //Metodo para listar doctores del hospital
        public void MostrarDoctores()
        {
            Console.WriteLine("Doctores en el Hospital:");
            foreach (Medico doctor in doctores)
            {
                doctor.Display();
                Console.WriteLine("-----------------------");
            }
        }

        //Metodo para listar pacientes del hospital
        public void MostrarPacientes()
        {
            Console.WriteLine("Pacientes en el Hospital:");
            foreach (Paciente paciente in pacientes)
            {
                paciente.Display();
                Console.WriteLine("-----------------------");
            }
        }

        //Metodo donde asignaremos los pacientes a un doctor especifico
        public void AsignarPacientes()
        {
            //Primero preguntamos por el id del doctor y el paciente
            Console.WriteLine("Dame el id del Doctor");
            int doctorId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame el id del Paciente para asignar al doctor");
            int pacienteId = Convert.ToInt32(Console.ReadLine());
            //Buscamos si se encuentra la id en nuestra lista
            Medico doctor = doctores.Find(d => d.Id == doctorId);
            Paciente paciente = pacientes.Find(p => p.Id == pacienteId);

            if(doctor != null && paciente != null)
            {
                //Comprobamos si nuestra lista esta null para poder asignar al paciente
                if(doctor.pacientes == null)
                {
                    doctor.pacientes = new List<Paciente>();
                }

                doctor.pacientes.Add(paciente);
                Console.WriteLine($"Paciente {paciente.Name} asignado a doctor {doctor.Name}");
            }
            else
            {
                Console.WriteLine("Doctor o paciente no asignado");
            }
        }

        //Metodo para eliminar Doctor
        public void EliminarDoctor(int id)
        {
            //Buscamos por la id del doctor para poder eliminarlo
            Medico doctorEliminado = doctores.Find(doctor => doctor.Id == id);
            if(doctorEliminado != null)
            {   
                doctores.Remove(doctorEliminado);
                Console.WriteLine("Doctor eliminado exitosamente");
            }
            else
            {
                Console.WriteLine("Doctor no encontrado");
            }
        }

        //Metodo para eliminar Paciente
        public void EliminarPaciente(int id)
        {
            //Buscamos por la id del paciente para poder eliminarlo
            Paciente pacienteEliminado = pacientes.Find(paciente => paciente.Id == id);
            if (pacienteEliminado != null)
            {
                pacientes.Remove(pacienteEliminado);
                Console.WriteLine("Paciente eliminado exitosamente");
            }
            else
            {
                Console.WriteLine("Paciente no encontrado");
            }
        }
    }
}
