namespace Domain.Entities
{
    public class Customer
    {

        public Customer(string name, string email, string document)
        {
            this.name = name;
            this.email = email;
            this.document = document;
        }

        public string name { get; private set; }
        public string email { get; private set; }
        public string document { get; private set; }

    }
}
