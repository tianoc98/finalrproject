using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProject1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FinalProject1.Data
{
    public class PaymentContext: IdentityDbContext
    {
        public virtual DbSet<PaymentData> DetailPayments { get; set; }
        public virtual DbSet<PaymentDetails> CardInfo { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }
        public PaymentContext(DbContextOptions<PaymentContext> options)
            : base(options)
        {

        }
    }
}
