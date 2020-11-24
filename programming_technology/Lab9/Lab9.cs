using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            Console.Title = "Лабораторная работа №9";
            Human h = new Human("Мухаммадкодир Абдувоитов", 19);
            h.Plus(6);
            h.Minus(2);
            h.DrawObject();

            Console.WriteLine("\n\n\n");

            Car car = new Car("Koenigsegg", "Regera", 403);
            car.Plus(25);
            car.Minus(11);
            car.DrawObject();

            Console.ReadKey();
        }
    }

    public class test: Idraw
    {
        public void GetStr()
        {
            return "data";
        }
    }

    interface Idraw
    {
        string GetStr();
    }

    public interface ICalculate
    {
        void Plus(int pPlus);
        void Minus(int pMinus);
    }

    public interface IVisual
    {
        string Name { get; set; }
        void DrawObject();
    }

    public class Human : ICalculate, IVisual    
    {
        private string FIO;
        private int Age;

        public string Name
        {
            get
            {
                return FIO + ":" + Age.ToString();
            }

            set
            {
                FIO = value;
            }
        }

        public Human(string pFIO, int pAge)
        {
            FIO = pFIO;
            Age = pAge;
        }

        public void Plus(int pPlus)
        {
            Age += pPlus;
        }

        public void Minus(int pMinus)
        {
            Age -= pMinus;
        }

        public void DrawObject()
        {
            Console.WriteLine(
                "     o     \n"+
                "  -------  \n"+
                "     |     \n"+
                "    / \\   \n"+
                "   /   \\  \n");
            Console.WriteLine(Name);
        }
    }

    public class Car: ICalculate, IVisual
    {
        private string Manufacturer;
        private string Model;
        private int Velocity;

        public Car(string pManufacturer, string pModel, int pVelocity)
        {
            Manufacturer = pManufacturer;
            Model = pModel;
            Velocity = pVelocity;
        }

        public string Name
        {
            get
            {
                return Manufacturer + " - " + Model + " : " + Velocity.ToString() + "km/h";
            }

            set
            {
                Model = value;
            }
        }

        public void DrawObject()
        {
            Console.WriteLine(
                "     ________\n" +
                " ___/________\\____\n"+
                "|#                o\\\n"+
                "|__(@)_________(@)__\\\n");
            Console.WriteLine(Name);
        }

        public void Minus(int pMinus)
        {
            Velocity -= pMinus;
        }

        public void Plus(int pPlus)
        {
            Velocity += pPlus;
        }
    }
}
