using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExceptionExercise.Models
{
    public class ExecptionExample
    {
        public void Metodo1()
        {   
            try 
            {
                Metodo2();
            } catch(Exception)
            {
                Console.WriteLine("Handle Exception");
            }
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            Metodo3();
        }
        public void Metodo4()
        {
            throw new Exception("An exception occurred..");
        }
    }

}