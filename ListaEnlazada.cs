using ExmJSVE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExmJSVE
{
    class ListaEnlazada
    {
        public Nodo principio;

        public ListaEnlazada()
        {
            principio = null;
        }

        public bool EstaVacia()
        {
            return principio == null;
        }
        public bool EstaLlena()
        {
            return principio != null;
        }

        //public void InsertarInicio(Persona persona)
        //{
        //    Nodo nuevoNodo = new Nodo(persona);
        //    nuevoNodo.Siguiente = principio;
        //    principio = nuevoNodo;
        //}
        public void Mostrar()
        {
            Nodo actual = principio;
            int longitud = 0;
            while (actual != null)
            {
                longitud++;
                Console.WriteLine($"Nombre:{actual.Dato.Nombre} Edad:{actual.Dato.Edad}");
                actual = actual.Siguiente;
            }
            Console.WriteLine($"LA LONGITUD ES DE: {longitud} PERSONAS");
        }
        public void InsertarFinal(Persona persona)
        {

            Nodo nuevoNodo = new Nodo(persona);
            if (principio == null)
            {
                principio = nuevoNodo;
                return;
            }
            Nodo actual = principio;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
        public void BuscarPersona(Persona persona)
        {

        }

        public void OrdenarAscendente(Persona persona)
        {

        }
    }
}