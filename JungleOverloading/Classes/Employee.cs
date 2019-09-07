using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JungleOverloading.Classes
{
    class Employee
    {
        string[] restaurants = { "McDonald's", "Wendy's", "Taco Bell", "Chick-Fil-A", "Pizza Hut" };

        string[] coworkers = { "Jim", "Pam", "Creed", "Michael", "Dwight" };

        public string first { get; set; }

        public string last { get; set; }

        public Employee(string firstName, string lastName)
        {
            first = firstName;
            last = lastName;
        }

        List<string> myRestaurants = new List<string>();

        public void MakeRestaurantList(string restaurant)
        {
            myRestaurants.Add(restaurant);
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            Console.WriteLine("Time for a lunch break");
            Eat(random.Next(min, max));
            return random.Next(min, max);
        }

        public string Eat(int index)
        {
            Random rand = new Random();
            int indexNum = rand.Next(restaurants.Length);
            Console.WriteLine($"{first} {last} likes to go to {restaurants[indexNum]}");
            return restaurants[index];
        }

        public string Eat(string meal)
        {
            Console.WriteLine($"{first} is eating {meal} at the office");
            return meal;
        }

        public void Eat(List<Employee> companions, string meal)
        {
            Console.Write($"{first} is out to lunch with ");

            foreach (var companion in companions)
            {
                string firstNameCompanion = companion.first;
                Console.Write($"{companion.first}, and ");
            }
            Console.Write($" and eating {meal}");
        }

    }
}
