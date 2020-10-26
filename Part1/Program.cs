/// Homework No. 7		Exercise Part 1
/// File Name: Odometer
/// @author: Evan Sinclair
/// Date:  Oct 26, 2020
///
/// Problem Statement: Define a class called Odometer that will be used to track fuel usage and miles per gallon. 
/// Create two constructors, 1 constructor should be the no-argument constructor the other will set the two instance 
/// variables. The class should have instance variables for mileage driven and fuel used.  Include a reset method 
/// that sets the mileage drive and the fuel used to zero.  Include an add method which takes two parameters that 
/// add to the fuel consumed and the miles driven.  Finally create a method that returns the miles per gallon and an 
/// appropriate ToString method.  Write a driver program that tests all the methods and constructors.  
/// 
/// 
/// Overall Plan:
/// 1)Build class Odometer with 2 instance variables, 2 constructors and all other required methods
/// 2)Test class Odometer with a driver that checks availible methods 
///
///

using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Odometer odo = new Odometer(20, 100);
            Console.WriteLine("new odometer");
            Console.WriteLine(odo.ToString());
            
            odo.ResetOdometer();
            Console.WriteLine("Odometer reset");
            Console.WriteLine(odo.ToString());

            Console.WriteLine("After add");
            odo.Add(500, 437.4);
            Console.WriteLine(odo.ToString());

            Console.WriteLine("MPG");
            Console.WriteLine(odo.MPG());



        }
    }
}
