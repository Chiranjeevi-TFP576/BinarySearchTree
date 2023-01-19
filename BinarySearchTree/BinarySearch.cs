using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearch<T> where T:IComparable<T>
    {
        public T Data;//root value
        public BinarySearch<T> left;
        public BinarySearch<T> right;
        public BinarySearch(T data)
        {
            this.Data = data;
            this.left = null;
            this.right = null;
        }
        int leftIndex = 0, rightIndex = 0;
        public void AddNode(T value)
        {
            T Nodevalue = this.Data;
            if (Nodevalue.CompareTo(value) > 0)
            {
                if (this.left == null) this.left = new BinarySearch<T>(value);
                else
                    this.left.AddNode(value);

            }
            else
            {
                if (this.right == null) this.right = new BinarySearch<T>(value);
                else
                    this.right.AddNode(value);
            }

        }
        public void Display()
        {
            if (this.left != null)
            {
                this.leftIndex++;
                this.left.Display();
            }
            Console.WriteLine(this.Data);
            if (this.right != null)
            {
                this.rightIndex++;
                this.right.Display();

            }

        }
    }
}




