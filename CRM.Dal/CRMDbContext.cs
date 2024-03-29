﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using CRM.Model.EntityModels;
using CRM.Model.EntityModels.CRM;

namespace CRM.Dal
{
    //在nuget 在线中安装EntityFramework
    //.net core 在nuget 在线中安装 EntityFrameworkCore
    public class CRMDbContext : DbContext
    {
        static CRMDbContext()
        {

        }
        public CRMDbContext() : base("name=CRMConnectionString")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//移除复数表名的契约

            ////数据库与实体映射--可以不设置
            //modelBuilder.Entity<Stock>().ToTable("Stock", "dbo");
            //modelBuilder.Entity<Sku>().ToTable("Sku", "dbo");
            //modelBuilder.Entity<BarCode>().ToTable("BarCode", "dbo");
            //modelBuilder.Entity<Product>().ToTable("Product", "dbo");
            ////联合主键
            //modelBuilder.Entity<PersonJob>().HasKey(t => new { t.PersonID, t.JobID }).ToTable("PersonJob", "dbo");
            //modelBuilder.Entity<Spouse>().ToTable("Spouse", "dbo");
        }

        public virtual DbSet<CheckOutOrder> CheckOutOrder { get; set; }
        public virtual DbSet<CheckOutOrderDetail> CheckOutOrderDetail { get; set; }
        public virtual DbSet<Deposit> Deposit { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<MemberAmount> MemberAmount { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<SystemCode> SystemCode { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
