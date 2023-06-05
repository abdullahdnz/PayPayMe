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
    public class CustomerAccountProcessManager : ICustomerAccountProcessService
    {
        private readonly ICustomerAccountProcessDal _customerAccountProcessDal;

        public CustomerAccountProcessManager(ICustomerAccountProcessDal _customerAccountProcessDal)
        {
            this._customerAccountProcessDal = _customerAccountProcessDal;
        }

        public void TDelete(CustomerAccountProcess entity)
        {
            _customerAccountProcessDal.Delete(entity);
        }

        public CustomerAccountProcess TGetByID(int id)
        {
            return _customerAccountProcessDal.GetByID(id);
        }

        public List<CustomerAccountProcess> TGetList()
        {
            return _customerAccountProcessDal.GetList();
        }

        public void TInsert(CustomerAccountProcess entity)
        {
            _customerAccountProcessDal.Insert(entity);
        }

        public void TUpdate(CustomerAccountProcess entity)
        {
            _customerAccountProcessDal.Update(entity);
        }
    }
}
