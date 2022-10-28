using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using SoftwareCourse1KnowledgeCheck2;

namespace VehicleWorkOrderManagementSystem
    {
        class Program
        {
        public static int numberOfRecords;

        public static void Main(string[] args)
            {
            Console.WriteLine("How many Work Orders would you like to add?");
            var numberOfRecords = int.Parse(Console.ReadLine());

                var workOrderList = new List<WorkOrder>();
                for (int i = 0; i <numberOfRecords; i++)
                {
                // In this loop, populate the object's properties using Console.ReadLine()
                var workOrder = new WorkOrder();

                Console.WriteLine("Enter the Client's name.");
                workOrder.ClientName = Console.ReadLine();

                Console.WriteLine("Please enter the Year of the vehicle.");
                workOrder.Year = Console.ReadLine();

                Console.WriteLine("Please enter the Manufacturer of the vehicle.");
                workOrder.Make = Console.ReadLine();

                Console.WriteLine("Please enter the Model of the vehicle.");
                workOrder.Model = Console.ReadLine();

                Console.WriteLine("Please enter the Color of the vehicle.");
                workOrder.Color = Console.ReadLine();

                Console.WriteLine("Please enter the presenting issue for the vehicle");
                workOrder.PresentingIssue = Console.ReadLine();

                workOrderList.Add(new WorkOrder() { ClientName = workOrder.ClientName, Year = workOrder.Year, Make = workOrder.Make, 
                    Model = workOrder.Model, Color = workOrder.Color, PresentingIssue = workOrder.PresentingIssue });

                }

            //Print out the list of records using Console.WriteLine()
            foreach (var WorkOrder in workOrderList)
                {
                Console.WriteLine("Hello " + WorkOrder.ClientName + " we would be happy to service " +
                    "your " + WorkOrder.Color + " " + WorkOrder.Year + " " + WorkOrder.Make + " " + WorkOrder.Model + ".");
                Console.WriteLine("It sounds like you are currently experiencing " + "' " + WorkOrder.PresentingIssue + " '");
                Console.WriteLine("We are so sorry that this is troubling you!");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("....");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("Our estimated current wait time is 263 Days and 13 Hours.");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("We approximate that it will cost $5,284.00");
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("Press any key to begin entering in your Credit Card information.");
                Console.ReadLine();
                }
            }
        }
    }
