using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Lab8
    {
        static void Main(string[] args)
        {
            Планшет samsung_tab = new Планшет("Samsung", "Exinos", 4, 64, "Android", 4999, 11);
            Мобильный iphone = new Мобильный("Apple", "Apple A14 Bionic", 6, 128, "iOS", 2873);
            Стационарный asus = new Стационарный("Asus", "Intel Core i9", 32, 1000, "Windows");

            Console.WriteLine(samsung_tab);
            Console.WriteLine(iphone);
            Console.WriteLine(asus);
            Console.ReadKey();
        }
    }

    class ЭВМ
    {
        string prosessor;
        string brand;
        int ram;
        int rom;

        public ЭВМ(string brand_, string prosessor_, int ram_, int rom_)
        {
            prosessor = prosessor_;
            brand = brand_;
            ram = ram_;
            rom = rom_;
        }

        public ЭВМ()
        {
            prosessor = "No info";
            brand = "No info";
            ram = 0;
            rom = 0;
        }
    }

    class Мобильный : ЭВМ
    {
        string os;
        int battery;

        public Мобильный()
            : base()
        {
            os = "No info";
            battery = 0;
        }

        public Мобильный(string brand_, string prosessor_, int ram_, int rom_, string os_, int battery_)
            : base(brand_, prosessor_, ram_, rom_)
        {
            os = os_;
            battery = battery_;
        }
    }

    class Стационарный : ЭВМ
    {

        string os;

        public Стационарный()
            : base()
        {
            os = "No info";
        }

        public Стационарный(string brand_, string prosessor_, int ram_, int rom_, string os_)
            : base(brand_, prosessor_, ram_, rom_)
        {
            os = os_;
        }
    }

    class Планшет : Мобильный
    {
        int screan_size;

        public Планшет()
            : base()
        {
            screan_size = 0;
        }

        public Планшет(string brand_, string prosessor_, int ram_, int rom_, string os_, int battery_, int screan_size_)
            : base(brand_, prosessor_, ram_, rom_, os_, battery_)
        {
            screan_size = screan_size_;
        }
    }

    class Ноутбук : Мобильный
    {
        int weight;

        public Ноутбук()
            : base()
        {
            weight = 0;
        }

        public Ноутбук(string brand_, string prosessor_, int ram_, int rom_, string os_, int battery_, int weight_)
            : base(brand_, prosessor_, ram_, rom_, os_, battery_)
        {
            weight = weight_;
        }
    }
}
