namespace HashtableBinarySearch
{
    class program
    {
        public static void Main(string[] args)
        {
            //MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            //hash.Add("0", "To");
            //hash.Add("1", "be");
            //hash.Add("2", "or");
            //hash.Add("3", "not");
            //hash.Add("4", "To");
            //hash.Add("5", "be");

            //string hash5 = hash.Get("5");
            //Console.WriteLine("5th index value: "+hash5);

            //string hash2 = hash.Get("2");
            //Console.WriteLine("2nd index value: " + hash2);




            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Add(30);
            binarySearch.Add(70);
            binarySearch.Add(22);
            binarySearch.Add(40);
            binarySearch.Add(60);
            binarySearch.Add(95);
            binarySearch.Add(11);
            binarySearch.Add(65);
            binarySearch.Add(3);
            binarySearch.Add(16);
            binarySearch.Add(63);
            binarySearch.Add(67);
            binarySearch.Display();
            binarySearch.GetSize();
            bool result = binarySearch.IfExists(67, binarySearch);
            Console.WriteLine(result);
        }
    }
}
