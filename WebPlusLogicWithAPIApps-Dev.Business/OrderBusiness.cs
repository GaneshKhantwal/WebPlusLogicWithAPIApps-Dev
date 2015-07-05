﻿using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPlusLogicWithAPIApps_Dev.Entity;

namespace WebPlusLogicWithAPIApps_Dev.Business
{
    public class OrderBusiness
    {
        public BusinessResult Create(OrderEntity orderEntity)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter() { ParameterName = "@RecipientName", SqlValue=orderEntity.RecipientName });
            paramList.Add(new SqlParameter() { ParameterName = "@DeliveryStreet", SqlValue = orderEntity.DeliveryStreet });
            paramList.Add(new SqlParameter() { ParameterName = "@DeliveryCity", SqlValue = orderEntity.DeliveryCity });
            paramList.Add(new SqlParameter() { ParameterName = "@DeliveryState", SqlValue = orderEntity.DeliveryState });
            paramList.Add(new SqlParameter() { ParameterName = "@DeliveryPostalCode", SqlValue = orderEntity.DeliveryPostalCode });
            paramList.Add(new SqlParameter() { ParameterName = "@Phone", SqlValue = orderEntity.Phone});
            paramList.Add(new SqlParameter() { ParameterName = "@Email", SqlValue = orderEntity.Email });
            paramList.Add(new SqlParameter() { ParameterName = "@OrderId", SqlValue = orderEntity.OrderId, Direction = System.Data.ParameterDirection.Output });
            int result = SqlHelper.ExecuteNonQuery(DBConnection.ConnectionString, System.Data.CommandType.StoredProcedure, "usp_CreateOrder", paramList.ToArray());
            
            return new BusinessResult(){ISuccess=true,Code="S",Message="Order Created Successfully."};
        }
    }
}
