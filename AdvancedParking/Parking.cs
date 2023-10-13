using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedParking
{
    internal class Parking : IDisposable
    {
        private string _parkingName;

        private string _parkingAddress; 

        private int _parkingCapacity;

        /// <summary>
        /// Constructor for Parking object
        /// </summary>
        /// <param name="parkingName"> </param> 
        /// <param name="parkingAddress"> </param> 
        /// <param name="parkingCapacity"> </param> 
        
        public Parking(string parkingName, string parkingAddress, int parkingCapacity)
        {
            _parkingName = parkingName;
            _parkingAddress = parkingAddress;
            _parkingCapacity = parkingCapacity;
        }
        /// <summary>
        /// Constructor for Parking object with predefined capacity
        /// </summary>
        /// <param name="parkingName"> </param> 
        /// <param name="parkingAddress"> </param> 
        
        public Parking(string parkingName, string parkingAddress)
        {
            _parkingName = parkingName;
            _parkingAddress = parkingAddress;
            _parkingCapacity = 250;
        }
        /// <summary>
        /// Constructor for Parking object with predefined name abd address
        /// </summary>
        /// <param name="parkingCapacity"> </param> 
        
        public Parking(int parkingCapacity)
        {
            _parkingName = "Public purking #17";
            _parkingAddress = "Green Heels st., 101";
            _parkingCapacity = parkingCapacity;
        }
        internal List<Car> cars = new List<Car>();

        /// <summary>
        /// Adding a new car to the parking 
        /// </summary>
        /// <param name="newCar"> </param> 
        
        public void AddNewCar(Car newCar)
        {
            if (cars.Count < _parkingCapacity)
            {
                newCar.ArrivalTime = DateTime.Now;
                cars.Add(newCar);
                Console.WriteLine($"A new car with registration number {newCar.RegistrationNumber} " +
                    $"arrived to the parking at {newCar.ArrivalTime}");
             }
            else
            {
                Console.WriteLine("No parking places available");
             
            }
        }
        /// <summary>
        /// Overloaded AddNewCar method. Uses car registration number as an input parameter
        /// </summary>
        /// <param name="registrationNumber"> </param> 
        public void AddNewCar(string registrationNumber)
        {

            Car newCar = new Car(new Random().Next(1, 10001), new Color(100), registrationNumber);

            if (cars.Count < _parkingCapacity)
            {
                newCar.ArrivalTime = DateTime.Now;
                cars.Add(newCar);
                Console.WriteLine($"A new car with registration number {newCar.RegistrationNumber} " +
                    $"arrived to the parking at {newCar.ArrivalTime}");
            }
            else
            {
                Console.WriteLine("No parking places available");

            }
        }
        /// <summary>
        /// Deleting car from the parking 
        /// </summary>
        /// <param name="carForRemove"> </param> 

        public void RemoveCar(Car carForRemove)
        {
            if (cars.Count > 0)
            {
                cars.RemoveAll(car => car.Id == carForRemove.Id);
                carForRemove.DepartureTime = DateTime.Now;
                Console.WriteLine($"The car with registration number {carForRemove.RegistrationNumber} " +
                    $"has left the parking. Departure time is {carForRemove.DepartureTime}");
            }

            else

            {
                Console.WriteLine("There are no cars to leave the parking");
            }
        }
        /// <summary>
        /// Overloaded method for deleting car from the parking by Id and registration number
        /// </summary>
        /// <param name="registrationNumber"> </param> 
        public void RemoveCar(int id, string registrationNumber)
        {
            if (cars.Count > 0)
            {
             Car ?carForRemove = cars.FirstOrDefault(car => car.Id == id && car.RegistrationNumber == registrationNumber);
             carForRemove.DepartureTime = DateTime.Now;
             cars.RemoveAll(car => (car.Id == id && car.RegistrationNumber == registrationNumber));
                
                Console.WriteLine($"The car {carForRemove.Brand} {carForRemove.Model} " +
                    $"with registration number {carForRemove.RegistrationNumber} " +
                    $"has left the parking. Departure time is {carForRemove.DepartureTime}");
            }
            else

            {
                Console.WriteLine("There are no cars to leave the parking");
            }
        }
        /// <summary>
        ///Getting all cars from parking list
        /// </summary>
        /// <returns> </returns> 
        public List<Car> GetAllCars()
        {
            return cars;
        }

        /// <summary>
        ///Reterns car parking status info
        /// </summary>
        /// <returns>Parking status info </returns>
        public void GetStateMessage()

        {
            Console.WriteLine($"Available parking spaces {_parkingCapacity - cars.Count} " +
                $" Occupied parking spaces {cars.Count}");
        }
        /// <summary>
        ///Reterns parking name and address
        /// </summary>
        /// <returns>Car parking general info </returns>
        public void GetParkingNameAddress()

        {
            Console.WriteLine("Parking general info:");
            Console.WriteLine($"Parking name:{_parkingName}");
            Console.WriteLine($"Parking address:{_parkingAddress}");
        }
        /// <summary>
        ///Dispose method for Parking class
        /// </summary>
        public void Dispose() 
        {
            Console.WriteLine("Checking dispose method. Parking is getting empty.");

            foreach (Car car in cars) 
            {
                car.DepartureTime = DateTime.Now;
                Console.WriteLine($"Car {car.Brand}, {car.Model}, {car.RegistrationNumber}, {car.DepartureTime}" +
                    $"is leaving the parking");
            }
            cars.Clear();
            Console.WriteLine($"Parking {this._parkingName}, {this._parkingAddress} is empty.");
        }
    }
}
    