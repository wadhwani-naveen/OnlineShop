﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModelLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PortalEntities : DbContext
    {
        public PortalEntities()
            : base("name=PortalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<OrderConfirmed> OrderConfirmeds { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductSize> ProductSizes { get; set; }
        public virtual DbSet<OrderCanceled> OrderCanceleds { get; set; }
        public virtual DbSet<WishList> WishLists { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
    
        public virtual ObjectResult<AlertProductDetails_Result> AlertProductDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AlertProductDetails_Result>("AlertProductDetails");
        }
    
        public virtual ObjectResult<DeliveryOrderData_Result> DeliveryOrderData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DeliveryOrderData_Result>("DeliveryOrderData");
        }
    
        public virtual ObjectResult<OrderConfirmData_Result> OrderConfirmData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<OrderConfirmData_Result>("OrderConfirmData");
        }
    }
}
