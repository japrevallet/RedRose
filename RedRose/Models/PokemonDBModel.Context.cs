﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RedRose.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RedRoseDBEntities : DbContext
    {
        public RedRoseDBEntities()
            : base("name=RedRoseDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChargedAttack> ChargedAttacks { get; set; }
        public virtual DbSet<ElementalTyping> ElementalTypings { get; set; }
        public virtual DbSet<FastAttack> FastAttacks { get; set; }
        public virtual DbSet<Pokemon> Pokemons { get; set; }
        public virtual DbSet<PrimaryTyping> PrimaryTypings { get; set; }
        public virtual DbSet<SecondaryTyping> SecondaryTypings { get; set; }
    }
}