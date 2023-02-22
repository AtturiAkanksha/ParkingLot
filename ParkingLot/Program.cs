using  System;
using System.Collections.Generic;


namespace ParkingLot
{
     class Program
    {

        public  static int SlotNumber = 0;
        public static void Main(string[] args)
        {
            List<Ticket> TwoWheelerArray = new List<Ticket> ();
            List<Ticket> FourWheelerArray = new List<Ticket>();
            List<Ticket> HeavyVehicleArray = new List<Ticket>();
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
           
            DateTime InTime ;

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
                                   
                                        InTime = DateTime.Now;

                                        Program.SlotNumber++;
                                        Console.WriteLine("Enter vehicle number:");
                                        string VehicleNumber = Console.ReadLine();
                                        Console.WriteLine("The slot for your vehicle is booked");
                                        Console.WriteLine("vehicle number: " + VehicleNumber);
                                        Console.WriteLine("slot number:" + SlotNumber);
                                        Console.WriteLine("entry: " + InTime);
                                        TwoWheelerArray.Add(new Ticket { VehicleNumber = VehicleNumber, SlotNumber = Convert.ToString(SlotNumber), EntryTime = Convert.ToString(InTime)});                                 
                                    Console.WriteLine("press enter to display main menu");
                                        TwoWheelerCount -= 1;
                                }
                                else
                                {
                                    Console.WriteLine("sorry! no slots for two weeler");
                                }

                                break;
                            case 2:
                                if (FourWheelerCount > 0)
                                {

                                    InTime = DateTime.Now;

                                    Program.SlotNumber++;
                                    Console.WriteLine("Enter vehicle number:");
                                    string VehicleNumber = Console.ReadLine();
                                    Console.WriteLine("The slot for your vehicle is booked");
                                    Console.WriteLine("vehicle number: " + VehicleNumber);
                                    Console.WriteLine("slot number:" + SlotNumber);
                                    Console.WriteLine("entry: " + InTime);
                                    FourWheelerArray.Add(new Ticket { VehicleNumber = VehicleNumber, SlotNumber = Convert.ToString(SlotNumber), EntryTime = Convert.ToString(InTime) });
                                    Console.WriteLine("press enter to display main menu");
                                    FourWheelerCount -= 1;
                                }
                                else
                                {
                                    Console.WriteLine("sorry! no slots for two weeler");
                                }

                                break;
                            case 3:
                                if (HeavyVehicleCount > 0)
                                {

                                    InTime = DateTime.Now;

                                    Program.SlotNumber++;
                                    Console.WriteLine("Enter vehicle number:");
                                    string VehicleNumber = Console.ReadLine();
                                    Console.WriteLine("The slot for your vehicle is booked");
                                    Console.WriteLine("vehicle number: " + VehicleNumber);
                                    Console.WriteLine("slot number:" + SlotNumber);
                                    Console.WriteLine("entry: " + InTime);
                                    HeavyVehicleArray.Add(new Ticket { VehicleNumber = VehicleNumber, SlotNumber = Convert.ToString(SlotNumber), EntryTime = Convert.ToString(InTime) });
                                    Console.WriteLine("press enter to display main menu");
                                    HeavyVehicleCount -= 1;
                                }
                                else
                                {
                                    Console.WriteLine("sorry! no slots for two weeler");
                                }

                                break;
                            default:
                                Console.WriteLine("Value didn't match earlier.");
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter vehicle number:");
                        string VehicleNumberCheck = Console.ReadLine();
                       
                        foreach (Ticket ticket in TwoWheelerArray.ToList())
                        {
                            if (ticket.VehicleNumber == VehicleNumberCheck)
                            {
                                Console.WriteLine("Your Vehicle is unparked");
                                TwoWheelerArray.Remove(ticket);
                                SlotNumber--;
                                Console.WriteLine(SlotNumber);
                                TwoWheelerCount++;
                                Console.WriteLine(TwoWheelerArray.Count);

                            }
                            else
                            {
                                Console.WriteLine("there is no vehicle with following details");
                            }
                        }
                        

                        foreach (Ticket ticket in FourWheelerArray.ToList())
                        {
                            if (ticket.VehicleNumber == VehicleNumberCheck)
                            {
                                Console.WriteLine("Your Vehicle is unparked");
                                FourWheelerArray.Remove(ticket);
                                SlotNumber--;
                                FourWheelerCount++;
                            }
                            else
                            {
                                Console.WriteLine("there is no vehicle with following details");
                            }
                        }
                        

                        foreach (Ticket ticket in HeavyVehicleArray.ToList())
                        {
                            if (ticket.VehicleNumber == VehicleNumberCheck)
                            {
                                Console.WriteLine("Your Vehicle is unparked");
                                HeavyVehicleArray.Remove(ticket);
                                HeavyVehicleCount++;
                                SlotNumber--;
                            }
                            else
                            {
                                Console.WriteLine("there is no vehicle with following details");
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Value didn't match earlier.");
                        break;
                }
                Console.ReadLine();
            }
        }
        public class Ticket
        {
            public string VehicleNumber { get; set; }
            public string SlotNumber { get; set; }
            public string EntryTime { get; set; }
        }
    }
    

}




