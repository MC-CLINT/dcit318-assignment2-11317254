using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IMovable
    {
        void Move();
    }


    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }


    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            IMovable myCar = new Car();
            IMovable myBicycle = new Bicycle();

            myCar.Move();
            myBicycle.Move();
        }
    }
}
