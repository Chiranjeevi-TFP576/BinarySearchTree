namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Binary SearchTree");
            BinarySearch<int> binarySearchTree = new BinarySearch<int>(56);
            binarySearchTree.AddNode(30);
            binarySearchTree.AddNode(70);         
            binarySearchTree.Display();
        }
    }
}