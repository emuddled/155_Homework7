﻿/// Homework No. 7		Exercise Part 2
/// File Name: Temperature
/// @author: Evan Sinclair
/// Date:  Oct 26, 2020
///
/// Problem Statement: Write a Temperature class that has two instance variables: a temperature value 
/// (a floating-point number) and a character for the scale, either C for Celsius of F for Fahrenheit.  
/// The class should have 4 constructor methods: one for each instance variable (assume zero degress 
/// if no value is specified and Celsius if no scale is specified), one with two parameters for the two 
/// instance variables, and a no-argument constructor (set to zero degrees Celsius).  Include the following:
///
/// Two getter methods to return the temperature, 1 of them to return the temperature in Celsius, the other 
/// to return the temperature in Fahrenheit. Return the value rounded to the nearest tenth of a degree.
/// 
/// Three setter methods, one to set the temperature, one to set the scale and one to set both instance variables.
/// 
/// A suitable ToString method.
/// 
/// An Equals method that compares two temperatures. Hint call the same getTemperature method and compare that.
/// 
/// A driver program that tests each of the constructors, each of the getters, each of the setter, the ToString 
/// method and the equals method, make sure that the Equals can return both true and false.
/// 
/// 
/// Overall Plan:
/// 1)Create class Temperature with proper variables and methods
/// 2)Test Temperature class by calling all methods and checking outputs
///
///
using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature tem = new Temperature();
            Console.WriteLine(tem.ToString());

            tem.SetTemp(122, 'F');
            Console.WriteLine(tem.ToString());

            

            Console.WriteLine(tem.GetTempC());
            Console.WriteLine(tem.GetTempF());
            Temperature otherTem = new Temperature(499);

            Console.WriteLine(tem.Equals(otherTem));
            Temperature otherTem2 = new Temperature(499, 'C');
            otherTem.Equals(otherTem2);

        }
    }
}
