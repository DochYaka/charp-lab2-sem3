public class Part2
{
    public void part2()
    {

        object[] technics = new object[]
        {
            new PC {Model = "ULTRA KILL PC", Weight = 6, Components = new Components {MotherBoard = true, CPU = true, PowerUnit = true, Storage = true, RAM = true} },
            new Tablet {Model = "Lenovo", Weight = 1, Storage = 128, RAM = 16, ScreenSize = 10, ScreenTech = TechOfScreen.AMOLED},
            new Printer {Model = "Printer eye", Weight = 2, TouchScreen = true, SpeedPrint = 2 },
            new Scaner {Model = "Scaner 3000", Weight = 3, TypeScan = TypeScan.Correctly}
        };

        foreach (var technic in technics)
        {
            Console.WriteLine($"\n\nТип: {technic.GetType().Name}");

            if (technic is PC pc)
            {
                pc.Print();
                Console.WriteLine("\nToString()");
                Console.WriteLine(pc.ToString());
            }

            else if (technic is Tablet tablet)
            {
                tablet.Print();
                Console.WriteLine("\nToString()");
                Console.WriteLine(tablet.ToString());
            }

            else if (technic is Printer printer)
            {
                printer.Print();
                Console.WriteLine("\nToString()");
                Console.WriteLine(printer.ToString());
            }

            else if (technic is Scaner scaner)
            {
                scaner.Print();
                Console.WriteLine("\nToString()");
                Console.WriteLine(scaner.ToString());
            }
        }




    }
}