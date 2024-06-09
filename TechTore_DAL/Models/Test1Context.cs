using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TechTore_DAL.Models;

public partial class Test1Context : DbContext
{
    public Test1Context()
    {
    }

    public Test1Context(DbContextOptions<Test1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Accounting> Accountings { get; set; }

    public virtual DbSet<Administrator> Administrators { get; set; }

    public virtual DbSet<AnalyticsDatum> AnalyticsData { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<CartItem> CartItems { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Discount> Discounts { get; set; }

    public virtual DbSet<Faq> Faqs { get; set; }

    public virtual DbSet<FeaturedProduct> FeaturedProducts { get; set; }

    public virtual DbSet<MarketingCampaign> MarketingCampaigns { get; set; }

    public virtual DbSet<ModeratorAction> ModeratorActions { get; set; }

    public virtual DbSet<NewsletterSubscription> NewsletterSubscriptions { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductImage> ProductImages { get; set; }

    public virtual DbSet<ProductSpecification> ProductSpecifications { get; set; }

    public virtual DbSet<ProductTag> ProductTags { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Shipment> Shipments { get; set; }

    public virtual DbSet<SocialMediaIntegration> SocialMediaIntegrations { get; set; }

    public virtual DbSet<Support> Supports { get; set; }

    public virtual DbSet<SupportTicket> SupportTickets { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserAddress> UserAddresses { get; set; }

    public virtual DbSet<UserMessage> UserMessages { get; set; }

    public virtual DbSet<UserRating> UserRatings { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<Wishlist> Wishlists { get; set; }

    public virtual DbSet<WishlistItem> WishlistItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-N2JM0CV;Database=test1;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Accounting>(entity =>
        {
            entity.HasKey(e => e.AccountingId).HasName("PK__Accounti__F309AA6917E3A48D");

            entity.ToTable("Accounting");

            entity.Property(e => e.AccountingId).HasColumnName("AccountingID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Accountings)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Accountin__UserI__49C3F6B7");
        });

        modelBuilder.Entity<Administrator>(entity =>
        {
            entity.HasKey(e => e.AdminId).HasName("PK__Administ__719FE4E86036847B");

            entity.Property(e => e.AdminId).HasColumnName("AdminID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Administrators)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Administr__UserI__46E78A0C");
        });

        modelBuilder.Entity<AnalyticsDatum>(entity =>
        {
            entity.HasKey(e => e.AnalyticsId).HasName("PK__Analytic__506974C3D53669E6");

            entity.Property(e => e.AnalyticsId).HasColumnName("AnalyticsID");
            entity.Property(e => e.Browser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeviceType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PageVisited)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.AnalyticsData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Analytics__UserI__74AE54BC");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("PK__Brands__DAD4F3BE40613E5E");

            entity.Property(e => e.BrandId).HasColumnName("BrandID");
            entity.Property(e => e.BrandName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Cart>(entity =>
        {
            entity.HasKey(e => e.CartId).HasName("PK__Cart__51BCD797FEFA6D02");

            entity.ToTable("Cart");

            entity.Property(e => e.CartId).HasColumnName("CartID");
            entity.Property(e => e.CartDate)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Carts)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Cart__UserID__619B8048");
        });

        modelBuilder.Entity<CartItem>(entity =>
        {
            entity.HasKey(e => e.CartItemId).HasName("PK__CartItem__488B0B2A693B48DF");

            entity.Property(e => e.CartItemId).HasColumnName("CartItemID");
            entity.Property(e => e.CartId).HasColumnName("CartID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Cart).WithMany(p => p.CartItems)
                .HasForeignKey(d => d.CartId)
                .HasConstraintName("FK__CartItems__CartI__6477ECF3");

            entity.HasOne(d => d.Product).WithMany(p => p.CartItems)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__CartItems__Produ__656C112C");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Categori__19093A2BC8B5ADD7");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Discount>(entity =>
        {
            entity.HasKey(e => e.DiscountId).HasName("PK__Discount__E43F6DF6F3C5D583");

            entity.Property(e => e.DiscountId).HasColumnName("DiscountID");
            entity.Property(e => e.EndDate)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Product).WithMany(p => p.Discounts)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Discounts__Produ__5EBF139D");

            entity.HasOne(d => d.User).WithMany(p => p.Discounts)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Discounts__UserI__5DCAEF64");
        });

        modelBuilder.Entity<Faq>(entity =>
        {
            entity.HasKey(e => e.Faqid).HasName("PK__FAQs__4B89D1E2E8D63DC9");

            entity.ToTable("FAQs");

            entity.Property(e => e.Faqid).HasColumnName("FAQID");
            entity.Property(e => e.Answer).HasColumnType("text");
            entity.Property(e => e.Question).HasColumnType("text");
        });

        modelBuilder.Entity<FeaturedProduct>(entity =>
        {
            entity.HasKey(e => e.FeaturedProductId).HasName("PK__Featured__302D908F07484CCE");

            entity.Property(e => e.FeaturedProductId).HasColumnName("FeaturedProductID");
            entity.Property(e => e.EndDate)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Product).WithMany(p => p.FeaturedProducts)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__FeaturedP__Produ__06CD04F7");
        });

        modelBuilder.Entity<MarketingCampaign>(entity =>
        {
            entity.HasKey(e => e.CampaignId).HasName("PK__Marketin__3F5E8D79FA5907EA");

            entity.Property(e => e.CampaignId).HasColumnName("CampaignID");
            entity.Property(e => e.Budget).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CampaignName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.EndDate)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.MarketingCampaigns)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Marketing__UserI__71D1E811");
        });

        modelBuilder.Entity<ModeratorAction>(entity =>
        {
            entity.HasKey(e => e.ActionId).HasName("PK__Moderato__FFE3F4B90B34C653");

            entity.Property(e => e.ActionId).HasColumnName("ActionID");
            entity.Property(e => e.ActionDescription)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ModeratorId).HasColumnName("ModeratorID");
            entity.Property(e => e.TargetUserId).HasColumnName("TargetUserID");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.Moderator).WithMany(p => p.ModeratorActionModerators)
                .HasForeignKey(d => d.ModeratorId)
                .HasConstraintName("FK__Moderator__Moder__4F7CD00D");

            entity.HasOne(d => d.TargetUser).WithMany(p => p.ModeratorActionTargetUsers)
                .HasForeignKey(d => d.TargetUserId)
                .HasConstraintName("FK__Moderator__Targe__5070F446");
        });

        modelBuilder.Entity<NewsletterSubscription>(entity =>
        {
            entity.HasKey(e => e.SubscriptionId).HasName("PK__Newslett__9A2B24BD7FC3D03F");

            entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SubscriptionDate)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.NewsletterSubscriptions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Newslette__UserI__01142BA1");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Orders__C3905BAFA8F549CC");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderDate)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Orders)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Orders__UserID__534D60F1");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.OrderItemId).HasName("PK__OrderIte__57ED06A1EDD99493");

            entity.Property(e => e.OrderItemId).HasColumnName("OrderItemID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__OrderItem__Order__5629CD9C");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__OrderItem__Produ__571DF1D5");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Payments__9B556A581FE41B79");

            entity.HasIndex(e => e.OrderId, "UQ__Payments__C3905BAE4AB1B230").IsUnique();

            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.PaymentDate)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Order).WithOne(p => p.Payment)
                .HasForeignKey<Payment>(d => d.OrderId)
                .HasConstraintName("FK__Payments__OrderI__7B5B524B");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__B40CC6ED47F2D1E6");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.BrandId).HasColumnName("BrandID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProductName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Brand).WithMany(p => p.Products)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK__Products__BrandI__3C69FB99");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__Products__Catego__3B75D760");
        });

        modelBuilder.Entity<ProductImage>(entity =>
        {
            entity.HasKey(e => e.ImageId).HasName("PK__ProductI__7516F4ECE43B08F3");

            entity.Property(e => e.ImageId).HasColumnName("ImageID");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ImageURL");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductImages)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__ProductIm__Produ__09A971A2");
        });

        modelBuilder.Entity<ProductSpecification>(entity =>
        {
            entity.HasKey(e => e.SpecificationId).HasName("PK__ProductS__A384CC1DFE6E7017");

            entity.Property(e => e.SpecificationId).HasColumnName("SpecificationID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.SpecificationName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SpecificationValue)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Product).WithMany(p => p.ProductSpecifications)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__ProductSp__Produ__778AC167");
        });

        modelBuilder.Entity<ProductTag>(entity =>
        {
            entity.HasKey(e => e.TagId).HasName("PK__ProductT__657CFA4CC3DD3659");

            entity.Property(e => e.TagId).HasColumnName("TagID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.TagName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Product).WithMany(p => p.ProductTags)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__ProductTa__Produ__0C85DE4D");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.ReviewId).HasName("PK__Reviews__74BC79AE816CC21D");

            entity.Property(e => e.ReviewId).HasColumnName("ReviewID");
            entity.Property(e => e.Comment).HasColumnType("text");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ReviewDate)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Product).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Reviews__Product__5AEE82B9");

            entity.HasOne(d => d.User).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Reviews__UserID__59FA5E80");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Roles__8AFACE3A53DDF1C6");

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Shipment>(entity =>
        {
            entity.HasKey(e => e.ShipmentId).HasName("PK__Shipment__5CAD378D083512CB");

            entity.HasIndex(e => e.OrderId, "UQ__Shipment__C3905BAEAEFEF120").IsUnique();

            entity.Property(e => e.ShipmentId).HasColumnName("ShipmentID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ShipmentDate)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TrackingNumber)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Order).WithOne(p => p.Shipment)
                .HasForeignKey<Shipment>(d => d.OrderId)
                .HasConstraintName("FK__Shipments__Order__18EBB532");
        });

        modelBuilder.Entity<SocialMediaIntegration>(entity =>
        {
            entity.HasKey(e => e.SocialMediaId).HasName("PK__SocialMe__3B026CFB282AEBB1");

            entity.ToTable("SocialMediaIntegration");

            entity.Property(e => e.SocialMediaId).HasColumnName("SocialMediaID");
            entity.Property(e => e.Platform)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProfileLink)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.SocialMediaIntegrations)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__SocialMed__UserI__03F0984C");
        });

        modelBuilder.Entity<Support>(entity =>
        {
            entity.HasKey(e => e.SupportId).HasName("PK__Support__D82DBC6C5E40D665");

            entity.ToTable("Support");

            entity.Property(e => e.SupportId).HasColumnName("SupportID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Supports)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Support__UserID__4CA06362");
        });

        modelBuilder.Entity<SupportTicket>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PK__SupportT__712CC627146EE165");

            entity.Property(e => e.TicketId).HasColumnName("TicketID");
            entity.Property(e => e.DateClosed)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.SupportTickets)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__SupportTi__UserI__6EF57B66");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCACAE2D9349");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserAddress>(entity =>
        {
            entity.HasKey(e => e.AddressId).HasName("PK__UserAddr__091C2A1BB48AF9AD");

            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Street)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithMany(p => p.UserAddresses)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__UserAddre__UserI__7E37BEF6");
        });

        modelBuilder.Entity<UserMessage>(entity =>
        {
            entity.HasKey(e => e.MessageId).HasName("PK__UserMess__C87C037C82FDB72A");

            entity.Property(e => e.MessageId).HasColumnName("MessageID");
            entity.Property(e => e.MessageContent).HasColumnType("text");
            entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");
            entity.Property(e => e.SenderId).HasColumnName("SenderID");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.Receiver).WithMany(p => p.UserMessageReceivers)
                .HasForeignKey(d => d.ReceiverId)
                .HasConstraintName("FK__UserMessa__Recei__151B244E");

            entity.HasOne(d => d.Sender).WithMany(p => p.UserMessageSenders)
                .HasForeignKey(d => d.SenderId)
                .HasConstraintName("FK__UserMessa__Sende__14270015");
        });

        modelBuilder.Entity<UserRating>(entity =>
        {
            entity.HasKey(e => e.UserRatingId).HasName("PK__UserRati__9E5FEAAAD46540CF");

            entity.Property(e => e.UserRatingId).HasColumnName("UserRatingID");
            entity.Property(e => e.Comment).HasColumnType("text");
            entity.Property(e => e.RatingDate)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.UserRatings)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__UserRatin__UserI__114A936A");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.UserRoleId).HasName("PK__UserRole__3D978A55BB61EE78");

            entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Role).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__UserRoles__RoleI__440B1D61");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__UserRoles__UserI__4316F928");
        });

        modelBuilder.Entity<Wishlist>(entity =>
        {
            entity.HasKey(e => e.WishlistId).HasName("PK__Wishlist__233189CB546D0CEB");

            entity.ToTable("Wishlist");

            entity.Property(e => e.WishlistId).HasColumnName("WishlistID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.WishlistDate)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.User).WithMany(p => p.Wishlists)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Wishlist__UserID__68487DD7");
        });

        modelBuilder.Entity<WishlistItem>(entity =>
        {
            entity.HasKey(e => e.WishlistItemId).HasName("PK__Wishlist__171E2181074E2F25");

            entity.Property(e => e.WishlistItemId).HasColumnName("WishlistItemID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.WishlistId).HasColumnName("WishlistID");

            entity.HasOne(d => d.Product).WithMany(p => p.WishlistItems)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__WishlistI__Produ__6C190EBB");

            entity.HasOne(d => d.Wishlist).WithMany(p => p.WishlistItems)
                .HasForeignKey(d => d.WishlistId)
                .HasConstraintName("FK__WishlistI__Wishl__6B24EA82");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
