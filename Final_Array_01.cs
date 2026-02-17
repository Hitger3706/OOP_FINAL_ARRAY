using System;

namespace ProductManagement
{
    class Product
    {
        private int _productId;
        private string _modelName;
        private double _price;

        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        public string ModelName
        {
            get { return _modelName; }
            set { _modelName = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Product(int id, string name, double price)
        {
            this.ProductId = id;
            this.ModelName = name;
            this.Price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {ProductId} | Model: {ModelName} | Price: {Price:F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Product[] products = new Product[3];

            Console.WriteLine("--- กรอกข้อมูลสินค้า 3 รายการ ---");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"\nรายการที่ {i + 1}:");

                Console.Write("ใส่รหัสสินค้า (ID): ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("ชื่อรุ่นสินค้า (Model Name): ");
                string name = Console.ReadLine();

                Console.Write("ราคาสินค้า (Price): ");
                double price = double.Parse(Console.ReadLine());

                products[i] = new Product(id, name, price);
            }

            Console.WriteLine("\n--- สรุปรายการสินค้าทั้งหมด ---");
            foreach (var item in products)
            {
                item.DisplayInfo();
            }

            Console.WriteLine("\nกดปุ่มใดก็ได้เพื่อจบโปรแกรม...");
            Console.ReadKey();
        }
    }
}