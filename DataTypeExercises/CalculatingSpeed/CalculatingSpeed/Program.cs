// Write a C# Sharp program that takes distance and time as input and displays the speed in kilometres per hour and miles per hour
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to speed calculation!");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();



            //Taking distance
            Console.WriteLine("Firstly insert your distance (meters): ");
                var MetersGiven = Console.ReadLine();
            if (IsItNumber(MetersGiven)) //checking distance
            {
                Console.WriteLine("Secoundly insert your time (hour): ");
                string HoursGiven = Console.ReadLine();
                if (IsItNumber(HoursGiven))
                {
                    Console.WriteLine("Secoundly insert your time (minutes): ");
                    string MinGiven = Console.ReadLine();
                    if (IsItNumber(MinGiven))
                    {
                        Console.WriteLine("Secoundly insert your time (seconds): ");
                        string SecGiven = Console.ReadLine();
                        if (IsItNumber(SecGiven))
                        {
                            double Meters = Convert.ToInt32(MetersGiven);
                            double Hours = Convert.ToInt32(HoursGiven);
                            double Mins = Convert.ToInt32(MinGiven);
                            double Secs = Convert.ToInt32(SecGiven);

                            //Speed in KM per h:
                            double timeHour = Hours + (Mins/60) + (Secs/3600);
                            double KM = Meters/1000;
                            double SpeedKMPerH = KM / timeHour;

                            Console.WriteLine("Your speed in km/h is "+ SpeedKMPerH);

                            //Speed in M per S
                            double timeSec = (Hours *3600) + (Mins*60) + Secs;
                            double SpeedMperS = Meters / timeSec;

                            Console.WriteLine("Your speed in meter/sec is " + SpeedMperS);

                            //Speed in miles/h

                            double miles = Meters / 1609.344;
                            double SpeedMilesPerH = miles / timeHour;

                            Console.WriteLine("Your speed in miles/h is " + SpeedMilesPerH);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Wrong input");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong input");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong input");
                    Console.ReadKey();
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wrong input");
                Console.ReadKey();
            }
        }
        public static bool IsItNumber(string str)
        {
            double number;
            if(double.TryParse(str, out number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
