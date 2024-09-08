using App.Domain.Entities.BaseData;
using App.Domain.Entities.Baskets;
using App.Domain.Entities.Blogs;
using App.Domain.Entities.Comments;
using App.Domain.Entities.Faqs;
using App.Domain.Entities.Learnings;
using App.Domain.Entities.Massages;
using App.Domain.Entities.NewsLetters;
using App.Domain.Entities.Orders;
using App.Domain.Entities.Payment;
using App.Domain.Entities.Products;
using App.Domain.Entities.Profiles;
using App.Domain.Entities.Roles;
using App.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.InfraStructure.Context
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<BaseEntity> BaseEntities { get; set; }
        public DbSet<ContactUs> contactUs { get; set; }
        public DbSet<PayRules> payRules { get; set; }
        public DbSet<ReturnRules> returnRules { get; set; }
        public DbSet<Rules> rules { get; set; }
        public DbSet<SaleRules> saleRules { get; set; }
        public DbSet<SendRules> sendRules { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<FaqCategory> FaqCategories { get; set; }
        public DbSet<Learning> Learnings { get; set; }
        public DbSet<LearningCategory> LearningCategories { get; set; }
        public DbSet<BaseDataMessage> baseDataMessages { get; set; }
        public DbSet<PushNotification> pushNotifications { get; set; }
        public DbSet<SMS> sMS { get; set; }
        public DbSet<SmsCode> SmsCodes { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductCapacity> ProductCapacities { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<ProductGallery> ProductGalleries { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<OrderList> OrderLists { get; set; }
        //public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserToken> UserTokens { get; set; }
    }
}
