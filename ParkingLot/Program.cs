using System;

namespace ParkingLot
{
     class Program
    {
         public static void Main(string[] args)
        {
            // ArrayList TwoWeelerArray = new ArrayList();
            // ArrayList FourWeelerArray = new ArrayList();
            // ArrayList HeavyVehicleArray = new ArrayList();
            int VehicleType;


            Console.WriteLine("Enter no. of slots for TwoWheeler Vehicles:");
            int TwoWheelerCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no. of slots for FourWheeler Vehicles:");
            int FourWheelerCount = Convert.ToInt32(Console.ReadLine());          
            Console.WriteLine("Enter no. of slots for HeavyVehicles:");
            int HeavyVehicleCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("slots available for TwoWheeler vehicles:" + TwoWheelerCount);
            Console.WriteLine("slots available for FourWheeler vehicles:" + FourWheelerCount);
            Console.WriteLine("slots available for HeavyVehicles:" + HeavyVehicleCount);
            Console.WriteLine("Welcome to ABC parking");
            while (true)
            {
                Console.WriteLine("select any one of the options: \n 1.Display slots available \n 2.Park the vehicle \n 3.Un-park the vehicle");
                int Option = Convert.ToInt32(Console.ReadLine());
                switch (Option)
                {
                    case 1:
                        Console.WriteLine("slots available for TwoWheeler vehicles:" + TwoWheelerCount);
                        Console.WriteLine("slots available for FourWheeler vehicles:" + FourWheelerCount);
                        Console.WriteLine("slots available for HeavyVehicles:" + HeavyVehicleCount);
                        break;
                    case 2:
                        Console.WriteLine("Select the vehicle type: \n 1.Two Wheeler \n 2.Four Wheeler \n 3.Heavy Vehicle");
                        VehicleType = Convert.ToInt32(Console.ReadLine());
                        switch (VehicleType)
                        {
                            case 1:
                                if (TwoWheelerCount > 0)
                                {
                                    for (int i = 1; i <= TwoWheelerCount; i++)
                                    {
                                        var InTime = DateTime.Now;
                                        int SlotNumber = i;
                                        Console.WriteLine("Enter vehicle number:");
                                        string VehicleNumber = Console.ReadLine();
                                        Console.WriteLine("The slot for your vehicle is booked");
                                        Console.WriteLine("vehicle number: " + VehicleNumber);
                                        Console.WriteLine("slot number:" + i);
                                        Console.WriteLine("entry time: " + InTime);
                                    }
                                    TwoWheelerCount -= 1;
                                    Console.WriteLine(TwoWheelerCount);
                                }
                                else
                                {
                                    Console.WriteLine("sorry! no slots for two weeler");
                                }

                                break;
                            case 2:
                                if (FourWheelerCount > 0)
                                {
                                    for (int i = 1; i <= FourWheelerCount; i++)
                                    {
                                        var InTime = DateTime.Now;
                                        int SlotNumber = i;
                                        Console.WriteLine("Enter vehicle number:");
                                        string VehicleNumber = Console.ReadLine();
                                        Console.WriteLine("The slot for your vehicle is booked");
                                        Console.WriteLine("vehicle number: " + VehicleNumber);
                                        Console.WriteLine("slot number:" + i);
                                        Console.WriteLine("entry time: " + InTime);

                                    }
                                    FourWheelerCount -= 1;
                                    Console.WriteLine(FourWheelerCount);
                                }
                                else
                                {
                                    Console.WriteLine("sorry! no slots for two weeler");
                                }
                                break;
                            case 3:
                                Console.WriteLine("Case 3");
                                break;
                            default:
                                Console.WriteLine("Value didn't match earlier.");
                                break;
                        }
                        break;
                    case 3:
                    //comment45
                    //console.writeline("vehicle number: " + vehiclenumber);
                    //console.writeline("slot number:" + i);
                    //console.writeline("entry time: " + intime);
                    //var outtime = datetime.now;
                    //console.writeline("exit time: " + outtime);
                    //console.writeline(vehiclenumber);
                    default:
                        Console.WriteLine("Value didn't match earlier.");
                        break;
                }
                Console.ReadLine();
            }

        }
    }
}