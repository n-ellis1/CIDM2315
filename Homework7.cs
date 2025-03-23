namespace Homework7;

    class Customer
    {
        // Private fields
        private int cust_id;
        private string cus_name;
        private int cus_age;

        // Constructor
        public Customer(int new_id, string cus_name, int cus_age)
        {
            this.cust_id = new_id;
            this.cus_name = cus_name;
            this.cus_age = cus_age;
        }

        public void ChangeID(int new_id)
        {
            this.cust_id = new_id;
        }

        public void PrintCustInfo()
        {
            Console.WriteLine($"Customer: {cust_id}, name: {cus_name}, age:{cus_age}");
        }

        // Compare ages and print the older customer's name
        public void CompareAge(Customer objCustomer)
        {
            if (this.cus_age > objCustomer.cus_age)
            {
                Console.WriteLine($"{this.cus_name} is older");
            }
            else
            {
                Console.WriteLine($"{objCustomer.cus_name} is older");
            }
        }

        // Update the customer's age if needed
        public void SetAge(int newAge)
        {
            this.cus_age = newAge;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(110, "Alice", 28);
            Customer c2 = new Customer(111, "Bob", 30);

            c1.PrintCustInfo();
            c2.PrintCustInfo();

            c1.ChangeID(220);
            c2.ChangeID(221);

            c1.SetAge(28);
            c2.SetAge(30);

            c1.PrintCustInfo();
            c2.PrintCustInfo();

            c1.CompareAge(c2);
        }
    }

