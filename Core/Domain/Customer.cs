namespace Domain
{
    public class Customer
    {
        public Customer(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }


        public string Name { get; }

        public int Age { get; }

        public bool CanCustomerRegister()
        {
            if (this.Age < 18)
            {
                return false;
            }

            return true;
        }
    }
}
