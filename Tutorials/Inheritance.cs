using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorials
{
    public abstract class Parent
    {
        public string name;
        public Parent(string _name)
        {
            Console.WriteLine("Parent constructor called");
            name = _name;
        }
    }

    public class Child : Parent
    {
        public int age;
        public Child(string _name, int _age):base(_name)
        {
            Console.WriteLine("Child constructor called");
            age = _age;
        }

        public override string ToString()
        {
            return "Name: "+ name + " Age: " + age;
        }
    } 


    public class Start
    {
        public static void Main1(string[] args)
        {
            var child = new Child("Ama", 2);
            Console.WriteLine(child);
        }
    }
}
