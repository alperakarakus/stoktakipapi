using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace stoktakip.Models;

public partial class StokTakip1824Context : DbContext
{
    public StokTakip1824Context()
    {
    }

    public StokTakip1824Context(DbContextOptions<StokTakip1824Context> options)
        : base(options)
    {
    }

    public virtual DbSet<TblKategoriler> TblKategorilers { get; set; }

    public virtual DbSet<TblKullanicilar> TblKullanicilars { get; set; }

    public virtual DbSet<TblMusteriler> TblMusterilers { get; set; }

    public virtual DbSet<TblStokCiki> TblStokCikis { get; set; }

    public virtual DbSet<TblStokGiris> TblStokGirises { get; set; }

    public virtual DbSet<TblTedarikciler> TblTedarikcilers { get; set; }

    public virtual DbSet<TblUrunler> TblUrunlers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=WIN-SERVER\\SQLEXPRESS;Initial Catalog=stok_takip_1824;Encrypt=False; User Id=sa;Password=admin.1;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblKategoriler>(entity =>
        {
            entity.HasKey(e => e.Kategoriid).HasName("PK_tblkategoriler");

            entity.ToTable("TblKategoriler");

            entity.Property(e => e.Kategoriid).HasColumnName("kategoriid");
            entity.Property(e => e.KategoriAd)
                .HasMaxLength(50)
                .HasColumnName("kategoriAd");
        });

        modelBuilder.Entity<TblKullanicilar>(entity =>
        {
            entity.HasKey(e => e.KullaniciId);

            entity.ToTable("TblKullanicilar");

            entity.Property(e => e.KullaniciAd).HasMaxLength(50);
            entity.Property(e => e.Parola).HasMaxLength(50);
        });

        modelBuilder.Entity<TblMusteriler>(entity =>
        {
            entity.HasKey(e => e.Musteriid);

            entity.ToTable("TblMusteriler");

            entity.Property(e => e.Musteriid).ValueGeneratedNever();
            entity.Property(e => e.Adres).HasMaxLength(200);
            entity.Property(e => e.FirmaAdi).HasMaxLength(100);
            entity.Property(e => e.Mail).HasMaxLength(50);
            entity.Property(e => e.Telefon).HasMaxLength(13);
            entity.Property(e => e.YetkiliAdSoyad).HasMaxLength(50);
        });

        modelBuilder.Entity<TblStokCiki>(entity =>
        {
            entity.HasKey(e => e.Islemid);

            entity.Property(e => e.Islemid)
                .ValueGeneratedNever()
                .HasColumnName("islemid");
            entity.Property(e => e.Adet).HasColumnName("adet");
            entity.Property(e => e.BirimFiyat).HasColumnName("birimFiyat");
            entity.Property(e => e.Tarih)
                .HasColumnType("date")
                .HasColumnName("tarih");
        });

        modelBuilder.Entity<TblStokGiris>(entity =>
        {
            entity.HasKey(e => e.IslemId);

            entity.ToTable("TblStokGiris");

            entity.Property(e => e.Tarih).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblTedarikciler>(entity =>
        {
            entity.HasKey(e => e.TedarikciId).HasName("PK_Table_1");

            entity.ToTable("TblTedarikciler");

            entity.Property(e => e.Adres).HasMaxLength(100);
            entity.Property(e => e.FirmaAdi).HasMaxLength(100);
            entity.Property(e => e.Mail).HasMaxLength(50);
            entity.Property(e => e.Tel).HasMaxLength(13);
            entity.Property(e => e.YetkiliAdSoyad).HasMaxLength(50);
        });

        modelBuilder.Entity<TblUrunler>(entity =>
        {
            entity.HasKey(e => e.Urunid);

            entity.ToTable("TblUrunler");

            entity.Property(e => e.Urunid).HasColumnName("urunid");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(150)
                .HasColumnName("aciklama");
            entity.Property(e => e.MaxStok).HasColumnName("maxStok");
            entity.Property(e => e.MinStok).HasColumnName("minStok");
            entity.Property(e => e.UrunAd)
                .HasMaxLength(50)
                .HasColumnName("urunAd");
            entity.Property(e => e.UrunKod).HasColumnName("urunKod");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
