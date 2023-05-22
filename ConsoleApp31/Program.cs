using System;
using System.Collections.Generic;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Numbers numbers1 = new Numbers();
            numbers1.a = 1;
            numbers1.b = 2;
            numbers1.c = 3;
            numbers1.d = 4;
            Numbers numbers2 = new Numbers();
            numbers2.a = numbers1.a;
            numbers2.b = numbers1.b;
            numbers2.c = numbers1.c;
            numbers2.d = numbers1.d;

            Square2 square1 = new Square2();
            square1.SetSqareSize(12);
            Console.WriteLine(square1.Area());
            Console.WriteLine(square1.Around());
        }
    }
    public class Numbers
    {
        public int a;
        public int b;
        public int c;
        public int d;
    }
    public class Square1
    {
        public void SetSqareSize(int size)
        {
            width = size;
            height = size;
        }
        protected int width;
        protected int height;
    }
    public class Square2 : Square1 // Inheritance toob mis on square1 poolel siia
    {
        public int Area()
        {
            return (width * height);
        }
        public int Around()
        {
            return ((2 * width) + (2 * height));
        }
    }
}
