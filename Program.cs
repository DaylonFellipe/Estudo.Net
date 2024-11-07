using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using ProjetoOportunidade.Entities;
using ProjetoOportunidade.Entities.Exceptions;


namespace ProjetoOportunidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date: ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-iout date: ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");

                Console.Write("Check-in date: ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-iout date: ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation " + reservation);
            }
            catch (DomainExeption e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            Console.ReadKey();
        }
    }
}

