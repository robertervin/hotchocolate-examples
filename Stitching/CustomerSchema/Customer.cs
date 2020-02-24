namespace Demo.Customers
{
    public class Customer
        : ICustomerOrConsultant
    {
        public CustomerIdentifiers Identifiers { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string ConsultantId { get; set; }
    }
}
