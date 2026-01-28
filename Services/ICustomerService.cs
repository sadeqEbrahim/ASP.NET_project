using GestionaleApi.Models;

namespace GestionaleApi.Services;

public interface ICustomerService
{
    IEnumerable<Customer> GetAll();
    Customer? GetById(int id);
    void Add(Customer customer);
}
