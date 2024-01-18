namespace WebApi.Models.AddCustomer
{
    public class AddCustomerInput
    {
        public string name { get; set; } = String.Empty;
        public string email { get; set; } = String.Empty;
        public string document { get; set; } = String.Empty;
    }
}