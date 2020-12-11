using System;
using AulaPOO_PolimorfismoSobrecarga.classes;

namespace AulaPOO_PolimorfismoSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos nossa classe Funcionario
            Funcionario fun = new Funcionario();
            fun.Mostrar();
            fun.Mostrar("Gustavo");
            fun.Mostrar(4);

            Console.Beep();
        }
    }
}
