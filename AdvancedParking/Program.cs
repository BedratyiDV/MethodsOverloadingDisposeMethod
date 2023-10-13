namespace AdvancedParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Color color1 = new Color(20, 20, 20, 20);
            Color color2 = new Color(30, 70, 00, 85);
            Color color3 = new Color(17, 65, 71);
            Color color4 = new Color(99);


            Car car1 = new Car(1, "Focus Titanium", "Ford", color1, "AI2012HB");
            Car car2 = new Car(2, "TT", "Audi", color2, "AH3333BK");
            Car car3 = new Car(3, "RAV-4", "Toyota", color1, "AX5033VT");
            Car car4 = new Car(4, color2, "AT1010FG");
            Car car5 = new Car("Civic", "Honda", color1, "AA4444BB");
                                      
           using (Parking parking1 = new Parking("Giant 4", "Liberty Square 1", 2))
           { 
            parking1.GetParkingNameAddress();
            parking1.GetStateMessage();

            parking1.AddNewCar(car1);
            parking1.AddNewCar(car2);
            parking1.AddNewCar(car3);

            parking1.RemoveCar(car2);

            parking1.AddNewCar(car3);

            parking1.GetStateMessage();
            
           List<Car> carlist =  parking1.GetAllCars();

           Console.WriteLine("All cars currently located on the parking:");

           foreach (Car car in carlist) 
            
            { 
                Console.WriteLine($"{car.RegistrationNumber} {car.ArrivalTime}"); 
            }

                Console.WriteLine("Checking overloaded Parking Remove car method:");
                parking1.RemoveCar(1, "AI2012HB");
                parking1.GetStateMessage();
            }

            car1.ChangeColor(color2);

            Console.WriteLine("Checking new constructors for Color class");
            Console.WriteLine($"Color 3 opacity:{color3.Opacity}");
            Console.WriteLine($"Color 4 :{color4.Red}, {color4.Green}, {color4.Blue}");

            Console.WriteLine("Checking new constructors for Car class");
            Console.WriteLine($"Car 4 brand and model :{car4.Brand}, {car4.Model}");
            Console.WriteLine($"Car 5 Id :{car5.Id}");

            Console.WriteLine("Checking new constructors for Parking class:");

            using (Parking parking2 = new Parking("Parking 2", "Address 2"))
            { 
                parking2.GetStateMessage();
            }

            using(Parking parking3 = new Parking(300))
            { 
            parking3.GetParkingNameAddress();
            }
            Console.WriteLine("Checking overloaded Parking Add method:");

            using (Parking parking4 = new Parking("Tetris", "August 23 st. 10/7", 3))

            { 
                parking4.GetStateMessage();
                parking4.GetParkingNameAddress();
                parking4.AddNewCar("AX7777AX");
                Console.WriteLine($"Details of arrived car: {parking4.cars?.FirstOrDefault()?.Id}," +
                $"{parking4.cars?.FirstOrDefault()?.RegistrationNumber}," +
                $"{parking4.cars?.FirstOrDefault()?.ArrivalTime}," +
                $"{parking4.cars?.FirstOrDefault()?.Brand}," +
                $"{parking4.cars?.FirstOrDefault()?.Model},");
            }
               
            

            


        }
    }
}