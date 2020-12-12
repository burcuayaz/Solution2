
using DataEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccsessLayer.EntityFramework
{

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=dataContext")
        {
            this.Configuration.ProxyCreationEnabled = false;

        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBL_KATEGORILER> TBL_KATEGORILER { get; set; }
        public virtual DbSet<TBL_KULLANICI> TBL_KULLANICI { get; set; }
        public virtual DbSet<TBL_MARKA> TBL_MARKA { get; set; }
        public virtual DbSet<TBL_MODEL> TBL_MODEL { get; set; }
        public virtual DbSet<TBL_MUSTERILER> TBL_MUSTERILER { get; set; }
        public virtual DbSet<TBL_SATIS> TBL_SATIS { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBL_KATEGORILER>()
                .Property(e => e.KATEGORI_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_KATEGORILER>()
                .HasMany(e => e.TBL_MARKA)
                .WithRequired(e => e.TBL_KATEGORILER)
                .HasForeignKey(e => e.KATEGORI_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_KATEGORILER>()
                .HasMany(e => e.TBL_MODEL)
                .WithRequired(e => e.TBL_KATEGORILER)
                .HasForeignKey(e => e.KATEGORI_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_KATEGORILER>()
                .HasMany(e => e.TBL_SATIS)
                .WithRequired(e => e.TBL_KATEGORILER)
                .HasForeignKey(e => e.KATEGORI_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_KULLANICI>()
                .Property(e => e.AD)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_KULLANICI>()
                .Property(e => e.SOYAD)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_KULLANICI>()
                .Property(e => e.MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_KULLANICI>()
                .Property(e => e.KULLANICI_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_KULLANICI>()
                .Property(e => e.SIFRE)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_MARKA>()
                .Property(e => e.MARKA_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_MARKA>()
                .HasMany(e => e.TBL_MODEL)
                .WithRequired(e => e.TBL_MARKA)
                .HasForeignKey(e => e.MARKA_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_MARKA>()
                .HasMany(e => e.TBL_SATIS)
                .WithRequired(e => e.TBL_MARKA)
                .HasForeignKey(e => e.MARKA_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_MODEL>()
                .Property(e => e.MODEL_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_MODEL>()
                .Property(e => e.VITES_TURU)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_MODEL>()
                .Property(e => e.RENK)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_MODEL>()
                .Property(e => e.FIYAT)
                .HasPrecision(28, 2);

            

            modelBuilder.Entity<TBL_MUSTERILER>()
                .Property(e => e.ADSOYAD)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_MUSTERILER>()
                .Property(e => e.TELEFON)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_MUSTERILER>()
                .Property(e => e.ADRES)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_MUSTERILER>()
                .Property(e => e.MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_MUSTERILER>()
                .HasMany(e => e.TBL_SATIS)
                .WithRequired(e => e.TBL_MUSTERILER)
                .HasForeignKey(e => e.MUSTERI_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_SATIS>()
                .Property(e => e.FIYAT)
                .HasPrecision(28, 2);
        }
    }
}
