using System;

namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfMovie = Console.ReadLine();

            int studentCounter = 0;
            int standardCounter = 0;
            int kidCounter = 0;

            while (nameOfMovie != "Finish")
            {
                int freePlaces = int.Parse(Console.ReadLine());
                int counter = 0;

                while (freePlaces > counter)
                {
                    string typeOfTicket = Console.ReadLine();

                    if (typeOfTicket == "End")
                    {
                        break;
                    }
                    if (typeOfTicket == "student")
                    {
                        studentCounter++;
                    }
                    else if (typeOfTicket == "standard")
                    {
                        standardCounter++;
                    }
                    else if (typeOfTicket == "kid")
                    {
                        kidCounter++;
                    }
                    counter++;
                }
                double averagePlaces = counter * 100.0 / freePlaces;
                Console.WriteLine($"{nameOfMovie} - {averagePlaces:f2}% full.");

                nameOfMovie = Console.ReadLine();
            }

            int allTickets = studentCounter + standardCounter + kidCounter;

            double percentStudentTicets = (double)studentCounter / allTickets * 100;
            double percentStandardTicets = (double)standardCounter / allTickets * 100;
            double percentKidTicets = (double)kidCounter / allTicket * 100;

            Console.WriteLine($"Total tickets: {allTickets}");
            Console.WriteLine($"{percentStudentTicets:f2}% student tickets.");
            Console.WriteLine($"{percentStandardTicets:f2}% standard tickets.");
            Console.WriteLine($"{percentKidTicets:f2}% kids tickets.");

        }
    }
}
