using System;
using System.Globalization;

namespace DateTimeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdueix una data: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            String dateString = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Introdueix el format utilitzat per la data: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            String dateFormat = Console.ReadLine();
            Console.ResetColor();
            try
            {
                DateTime dateIn = DateTime.ParseExact(dateString, dateFormat, CultureInfo.InvariantCulture);
                if (!dateIn.TimeOfDay.Equals(TimeSpan.Zero))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("Error, s'esperaba un data y s'ha especificat mes informació de la necessaria o el format no es correcte.");
                    Console.ResetColor();
                }
                else
                {
                    var days = (DateTime.Today - dateIn).TotalDays;

                    if (days == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("Ha passat " + days + " dia desde el dia '" + dateIn.ToString(dateFormat) + "'");
                        Console.ResetColor();
                    }
                    else if (days > 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("Han passat " + days + " dies desde el dia '" + dateIn.ToString(dateFormat) + "'");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine("Encara no s'ha arribat al dia '" + dateIn.ToString(dateFormat) + "'");
                        Console.ResetColor();
                    }

                }
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Error, el format no es correcte o no coincidex amb la data.");
                Console.ResetColor();
            }

            Console.WriteLine();
            Console.WriteLine("Introdueix una hora: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            String timeString = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Introdueix el format utilitzat per la hora: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            String timeFormat = Console.ReadLine();
            Console.ResetColor();

            try
            {
                TimeSpan timeIn = TimeSpan.ParseExact(timeString, timeFormat, CultureInfo.InvariantCulture);
                var interval = DateTime.Now - timeIn;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("Han passat "+interval.Hour+" hores i "+interval.Minute+" minuts desde les "+ timeIn);
                Console.ResetColor();

            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Error, el format no es correcte o no coincidex amb la hora.");
                Console.ResetColor();
            }

        }
    }
}