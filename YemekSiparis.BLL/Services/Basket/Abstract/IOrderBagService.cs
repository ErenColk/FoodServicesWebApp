﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YemekSiparis.Core.Entities;

namespace YemekSiparis.BLL.Services.Basket.Abstract
{
    public interface IOrderBagService : IBaseService<OrderBag> 
    {

        Task<int> GetOrderBagID(OrderBag orderBag);

        Task<decimal> TotalPayment(List<OrderDetail> orderDetails);

        Task<bool> DefaultUpdate(OrderBag orderBag);

        Task<List<OrderBag>> GetAllIncludeOrderss(Expression<Func<OrderBag,bool>> expression,params Expression<Func<OrderBag, object>>[]  includes);

    }
}
