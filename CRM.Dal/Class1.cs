﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using System.Data.SqlClient;

namespace CRM.Dal
{
    public class Class1
    {
        public void Test()
        {
            using (CRMDbContext dbContext = new Dal.CRMDbContext())
            {

            }
            using (SqlConnection con=new SqlConnection ())
            {
                //con.Query<>
            }
        }
    }
}
