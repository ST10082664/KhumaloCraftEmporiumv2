﻿namespace KhumaloCraftEmporium.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public string PurchaseHistory { get; set; }
        public ICollection<Transactions> Transactions { get; set; }
    }
}
