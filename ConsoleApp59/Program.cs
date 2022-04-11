using System;

namespace LearnCSharp.Cmd
{
    public class Program
    {
        static void Main()
        {
            ShoppingBag<Bag> shoppingBag = new ShoppingBag<Bag>();
            
       
            var counter = 0;
            while (counter < 5)
            {
                Console.WriteLine(shoppingBag.GetItem(counter));
                counter++;
            }
        }
    }

    public class ShoppingBag<T> where T : Bag
    {
        private T[] _items = new T[5];
        private int _index = 0;
        public void AddItem(T item)
        {
            _items[_index++] = item;
        }

        public T GetItem(int index)
        {
            return _items[index];
        }
    }

    public class Bag
    {
       


    }
}