﻿using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
        List<CustomerDetailDto> GetCustomerDetails();
        CustomerDetailDto GetCustomerDetailsDetailsById(int customerId);
        CustomerDetailDto GetCustomerDetailsByUserId(int userId);
    }
}
