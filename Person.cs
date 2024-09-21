using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal record class Person(string F_Name,string L_Name,int Age);

    static class PersonExtensions
    {
        public static int AverageAge(this Person[] persons)
        {
            int totalAge = 0;
            for (int i = 0; i < persons.Length; i++)
            {
                totalAge += persons[i].Age;
            }
            return totalAge / persons.Length;
        }
    }
}
