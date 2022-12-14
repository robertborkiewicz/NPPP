using X.PagedList;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;

using appCnfg = NPPP.Data.AppConfig;

namespace NPPP.Data
{
    public class CustomerService
    {
        public NPPPDbContext _NPPPDbContext;

        public int PageCount { get; set; }

        public IEnumerable<Customer> GetCustomers(int pageNumber, string searchString)
        {
    
            var contextOptions = new DbContextOptionsBuilder<NPPPDbContext>()
                .UseSqlServer(appCnfg.ConnectionString)
                .Options;

            _NPPPDbContext = new NPPPDbContext(contextOptions);

            IQueryable<Customer> customerQuery;
            if (String.IsNullOrEmpty(searchString))
            {
                customerQuery = from customer in _NPPPDbContext.Customers
                                select customer;
            }
            else
            {
                customerQuery = from customer in _NPPPDbContext.Customers
                                where customer.FirstName.Contains(searchString) ||
                                      customer.LastName.Contains(searchString) ||
                                      customer.PESEL.Contains(searchString) ||
                                      customer.ParentFirstName.Contains(searchString) ||
                                      customer.ParentLastName.Contains(searchString) ||
                                      customer.ParentPESEL.Contains(searchString) ||
                                      customer.ParentPhone.Contains(searchString) ||
                                      customer.ParentEmail.Contains(searchString) ||
                                      customer.AddressStreet.Contains(searchString) ||
                                      customer.AddressCity.Contains(searchString)
                                select customer;
            }
            
            IPagedList<Customer> customers=customerQuery.ToPagedList(pageNumber, appCnfg.PageSize);
            PageCount = customers.PageCount;
            return customers;
        }
    }
}
