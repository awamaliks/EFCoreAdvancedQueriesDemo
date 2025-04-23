
using System;
using System.Diagnostics.Tracing;
using System.Linq;
using EFCoreAdvancedQueriesDemo.Data;
using EFCoreAdvancedQueriesDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAdvancedQueriesDemo
{
    

   



    class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();

            //Console.WriteLine("List All Employees");
            //context.Employees.ToList().ForEach(e => Console.WriteLine(e.Name));

            //Projection
            //Console.WriteLine("Employees Name and Salaries");
            //var projection = context.Employees.Select(x => new { x.Name, x.Salary }).ToList();
            //foreach (var employee in projection)
            //{
            //    Console.WriteLine($"{employee.Name} - {employee.Salary}");
            //}

            //Filtering
            //Console.WriteLine("High Earners");

            //var HighEarners = context.Employees.Where(e => e.Salary > 6000).ToList();

            //foreach (var employee in HighEarners) {
            //    Console.WriteLine($"{employee.Name} - {employee.Salary}");
            //}

            //Ordering
            //Console.WriteLine("Order By Salary");
            //var OrderedData = context.Employees.Where(e => e.Salary > 6000).OrderBy(context => context.Salary).ToList();

            // foreach (var employee in OrderedData)
            //    {
            //        Console.WriteLine($"{employee.Name} - {employee.Salary}");
            //    }

            //Grouping
            //Console.WriteLine("Grouping Based on Department");
            //var GroupedData = context.Employees.Include(x => x.Department).ToList().GroupBy(d => d.Department.Name);
            //foreach (var d in GroupedData)
            //{
            //    Console.WriteLine("Department" + d.Key);
            //    foreach(var emp in d)
            //    {
            //        Console.WriteLine($"{emp.Name}");
            //    }
            //}

            //Pagination
            Console.WriteLine("Pagination Data (Page 1, Size 2):");
            var PageNo = 2;
            var PageSize = 10;
            var PagingData = context.Employees.Skip((PageNo-1) * PageSize).Take(PageSize).ToList();
            foreach (var p in PagingData)
            {
                Console.WriteLine($"{p.Name}");
            }

            Console.ReadLine();
           
        }
    }
}
