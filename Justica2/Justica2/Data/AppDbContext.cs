using Justica2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Settings> Settings { get; set; }
        public DbSet<SettingSocial> SettingSocials { get; set; }
        public DbSet<PracticeArea> PracticeAreas { get; set; }
        public DbSet<AllPracticeAreas> AllPracticeAreas { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<FaqPart> FaqParts { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Law> Laws { get; set; }
        public DbSet<Legal> Legals { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsToTag> NewsToTags { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Our> Ours { get; set; }
        public DbSet<OurPart> OurParts { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Subheader> Subheaders { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamSocial> TeamSocials { get; set; }
        public DbSet<TeamToSocial> TeamToSocials { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<WeDidPart> WeDidParts { get; set; }
        public DbSet<WhatWeDid> WhatWeDids { get; set; }
        public DbSet<PracticeAreaName> PracticeAreaNames { get; set; }
        public DbSet<NewsName> NewsNames { get; set; }
    }
}
