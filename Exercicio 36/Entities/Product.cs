using System;
using System.Text;

namespace Exercicio_36.Entities
{
    internal class Product : IComparable
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(Name + ", " + Price.ToString("F2"));

            return stringBuilder.ToString();
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Product))
            {
                throw new Exception("Comparação errado");
            }

            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}
