using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Abstract;
using EasyCashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{

    public class CustomerAccountManager : ICustomerAccountService
    {
        private readonly ICustomerAccountDal _customerAccountDal;
        public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
        {
            _customerAccountDal = customerAccountDal;
        }

        CustomerAccount ICustomerAccountService.TDelete(CustomerAccount t)
        {
            throw new NotImplementedException();
        }

        CustomerAccount IGenericService<CustomerAccount>.TDelete(CustomerAccount t)
        {
            throw new NotImplementedException();
        }
    }
}
