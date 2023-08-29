namespace Customer.DAL.IRepositories
{
    public interface ICustomerRepository
    {
        Task Add(Domains.Customer customer);
        Task<IEnumerable<Domains.Customer>> GetAll();
        Task Commit();
    }
}