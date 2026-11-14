using System;
using System.Collections.Generic;

namespace Decode
{
    // 1.
    class Device
    {
        public string Name { get; set; }
        public string Characteristics { get; set; }

        public Device(string name, string characteristics)
        {
            Name = name;
            Characteristics = characteristics;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Device making sound.");
        }

        public virtual void Show()
        {
            Console.WriteLine("Name: " + Name);
        }

        public virtual void Desc()
        {
            Console.WriteLine("Characteristics: " + Characteristics);
        }
    }

    class Kettle : Device
    {
        public Kettle(string name, string characteristics)
            : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Kettle whistling!");
        }
    }

    class Microwave : Device
    {
        public Microwave(string name, string characteristics)
            : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Microwave beeping!");
        }
    }

    class Car : Device
    {
        public Car(string name, string characteristics)
            : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Car honking!");
        }
    }

    class Steamboat : Device
    {
        public Steamboat(string name, string characteristics)
            : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Steamboat tooting!");
        }
    }

    // 2.
    class Course
    {
        public string Name { get; set; }
        public int Duration { get; set; }

        public Course(string name, int duration)
        {
            Name = name;
            Duration = duration;
        }

        public override string ToString()
        {
            return $"Course name: {Name}\n" +
                   $"Duration: {Duration} hours";
        }
    }

    class OnlineCourse : Course
    {
        public string Platform { get; set; }

        public OnlineCourse(string name, int duration, string platform)
            : base(name, duration)
        {
            Platform = platform;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\nPlatform: {Platform}";
        }
    }

    // 3.
    abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract double CalculateDiscount();
    }

    class Electronics : Product
    {
        public Electronics(string name, double price)
            : base(name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return Price * 0.10;
        }
    }

    class Furniture : Product
    {
        public Furniture(string name, double price)
            : base(name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return Price * 0.15;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Device[] devices =
            {
                new Kettle("Kettle", "Power: 2000 W, Volume: 2 liters"),
                new Microwave("Microwave", "Power: 800 W, Volume: 20 liters"),
                new Car("Car", "Engine: 2.0 L, Power: 150 HP"),
                new Steamboat("Steamboat", "Engine: Steam, Speed: 30 km/h")
            };

            foreach (Device device in devices)
            {
                Console.WriteLine("\n--------------------");
                device.Show();
                device.Desc();
                device.Sound();
            }

            // Task 2
            Course course = new Course("Programming basics", 40);

            OnlineCourse onlineCourse = new OnlineCourse("Learning Python", 30, "Coursera");

            Console.WriteLine("--- Offline course ---");
            Console.WriteLine(course);

            Console.WriteLine("\n--- Online course ---");
            Console.WriteLine(onlineCourse);

            // Task 3
            List<Product> products = new List<Product>
            {
                new Electronics("Smartphone", 800),
                new Furniture("Sofa", 1200)
            };

            foreach (Product product in products)
            {
                double discount = product.CalculateDiscount();

                Console.WriteLine($"\nProduct: {product.Name}");
                Console.WriteLine($"Price: ${product.Price:F2}");
                Console.WriteLine($"Discount: ${product.CalculateDiscount():F2}");
                Console.WriteLine($"Price after discount: ${product.Price - discount:F2}");
                Console.WriteLine("--------------------");
            }
        }
    }
}