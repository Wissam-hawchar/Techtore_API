using System;
using System.Collections.Generic;

namespace TechTore_DAL.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<Accounting> Accountings { get; set; } = new List<Accounting>();

    public virtual ICollection<Administrator> Administrators { get; set; } = new List<Administrator>();

    public virtual ICollection<AnalyticsDatum> AnalyticsData { get; set; } = new List<AnalyticsDatum>();

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual ICollection<Discount> Discounts { get; set; } = new List<Discount>();

    public virtual ICollection<MarketingCampaign> MarketingCampaigns { get; set; } = new List<MarketingCampaign>();

    public virtual ICollection<ModeratorAction> ModeratorActionModerators { get; set; } = new List<ModeratorAction>();

    public virtual ICollection<ModeratorAction> ModeratorActionTargetUsers { get; set; } = new List<ModeratorAction>();

    public virtual ICollection<NewsletterSubscription> NewsletterSubscriptions { get; set; } = new List<NewsletterSubscription>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual ICollection<SocialMediaIntegration> SocialMediaIntegrations { get; set; } = new List<SocialMediaIntegration>();

    public virtual ICollection<SupportTicket> SupportTickets { get; set; } = new List<SupportTicket>();

    public virtual ICollection<Support> Supports { get; set; } = new List<Support>();

    public virtual ICollection<UserAddress> UserAddresses { get; set; } = new List<UserAddress>();

    public virtual ICollection<UserMessage> UserMessageReceivers { get; set; } = new List<UserMessage>();

    public virtual ICollection<UserMessage> UserMessageSenders { get; set; } = new List<UserMessage>();

    public virtual ICollection<UserRating> UserRatings { get; set; } = new List<UserRating>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

    public virtual ICollection<Wishlist> Wishlists { get; set; } = new List<Wishlist>();
}
