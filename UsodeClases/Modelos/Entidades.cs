using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsodeClases.Modelos
{
    public class Persona
    {
        // Propiedades de la clase Persona
        public string nombres; //Jenny
        public string apellidos; // Henriquez 
        public int edad; //19
        public DateTime fechaNacimiento; //31-05-2005
        public string docuemnto;  //08523652-0
        public string telefono; //77037776
        public string direccion; //Chalatenango
        public string email; //jennhrqzsvgmail.com

        //Constructor

        public Persona(string nombres, string apellidos, int edad, DateTime fechaNacimiento, string documento, string telefono, string direccion, string email)
        {
                this.nombres = nombres;
                this.apellidos = apellidos;
                this.edad = edad;
                this.fechaNacimiento = fechaNacimiento;
                this.docuemnto = documento;
                this.telefono = telefono;
                this.direccion = direccion;
                this.email = email;
        }

        //Metodos 
        public string MostrarDatos()
        {
            return $"Nombre: {this.nombres}\nApellidos: {this.apellidos}\nEdad: {this.edad}\nEmail: {this.email}\nTelefono: {this.telefono}\nDireccion: {this.direccion}\n";
        }


    }
}
