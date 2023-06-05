using PayPayMe.Business.Abstract;
using PayPayMe.DataAccess.Abstract;
using PayPayMe.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPayMe.Business.Concrete
{
    public class CustomerAccountManager : ICustomerAccountService
    {
        private readonly ICustomerAccountDal _customerAccountDal;

        public CustomerAccountManager(ICustomerAccountDal _customerAccountDal)
        {
            this._customerAccountDal = _customerAccountDal;
        }

        public void TDelete(CustomerAccount entity)
        {
            _customerAccountDal.Delete(entity);
        }

        public CustomerAccount TGetByID(int id)
        {
            return _customerAccountDal.GetByID(id);
        }

        public List<CustomerAccount> TGetList()
        {
            return _customerAccountDal.GetList();
        }

        public void TInsert(CustomerAccount entity)
        {
            _customerAccountDal.Insert(entity);
        }

        public void TUpdate(CustomerAccount entity)
        {
            _customerAccountDal.Update(entity);
        }
    }
}
