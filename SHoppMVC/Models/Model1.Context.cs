﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SHoppMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShopEntities : DbContext
    {
        public ShopEntities()
            : base("name=ShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<accountLog> accountLog { get; set; }
        public virtual DbSet<AdminInfo> AdminInfo { get; set; }
        public virtual DbSet<adminLog> adminLog { get; set; }
        public virtual DbSet<adminState> adminState { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<article> article { get; set; }
        public virtual DbSet<attribute> attribute { get; set; }
        public virtual DbSet<backGoods> backGoods { get; set; }
        public virtual DbSet<cart> cart { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Goods> Goods { get; set; }
        public virtual DbSet<goodsImg> goodsImg { get; set; }
        public virtual DbSet<goodsType> goodsType { get; set; }
        public virtual DbSet<income> income { get; set; }
        public virtual DbSet<InStorage> InStorage { get; set; }
        public virtual DbSet<massage> massage { get; set; }
        public virtual DbSet<OrderInfo> OrderInfo { get; set; }
        public virtual DbSet<orderLog> orderLog { get; set; }
        public virtual DbSet<payment> payment { get; set; }
        public virtual DbSet<reply> reply { get; set; }
        public virtual DbSet<Resource> Resource { get; set; }
        public virtual DbSet<role> role { get; set; }
        public virtual DbSet<RoleRight> RoleRight { get; set; }
        public virtual DbSet<supplier> supplier { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<userAddress> userAddress { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<XFgoodimg> XFgoodimg { get; set; }
    }
}
