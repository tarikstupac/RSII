using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VGFeed.WebAPI.Database
{
    public partial class _3123Context : DbContext
    {
        public _3123Context()
        {
        }

        public _3123Context(DbContextOptions<_3123Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Donacije> Donacije { get; set; }
        public virtual DbSet<Drzave> Drzave { get; set; }
        public virtual DbSet<Igre> Igre { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }
        public virtual DbSet<KorisnikIgre> KorisnikIgre { get; set; }
        public virtual DbSet<KorisnikSocials> KorisnikSocials { get; set; }
        public virtual DbSet<Platforme> Platforme { get; set; }
        public virtual DbSet<Poruke> Poruke { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<SaleDetalji> SaleDetalji { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<Uloge> Uloge { get; set; }
        public virtual DbSet<Zanrovi> Zanrovi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=3123;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Donacije>(entity =>
            {
                entity.HasKey(e => e.DonacijaId);

                entity.Property(e => e.DatumUplate).HasColumnType("datetime");

                entity.Property(e => e.Token).IsRequired();

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Donacije)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK__Donacije__Korisn__02FC7413");
            });

            modelBuilder.Entity<Drzave>(entity =>
            {
                entity.HasKey(e => e.DrzavaId);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Igre>(entity =>
            {
                entity.HasKey(e => e.IgraId);

                entity.Property(e => e.DatumIzlaska).HasColumnType("datetime");

                entity.Property(e => e.Developer)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Izdavac)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.Platform)
                    .WithMany(p => p.Igre)
                    .HasForeignKey(d => d.PlatformId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Igre__PlatformId__778AC167");

                entity.HasOne(d => d.Zanr)
                    .WithMany(p => p.Igre)
                    .HasForeignKey(d => d.ZanrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Igre__ZanrId__787EE5A0");
            });

            modelBuilder.Entity<Korisnici>(entity =>
            {
                entity.HasKey(e => e.KorisnikId);

                entity.Property(e => e.BrojTelefona)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DatumKreiranja).HasColumnType("date");

                entity.Property(e => e.DatumRodjenja).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Spol)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Korisnici)
                    .HasForeignKey(d => d.DrzavaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Korisnici__Drzav__5165187F");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.Korisnici)
                    .HasForeignKey(d => d.UlogaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Korisnici__Uloga__52593CB8");
            });

            modelBuilder.Entity<KorisnikIgre>(entity =>
            {
                entity.Property(e => e.Recenzija).HasColumnType("text");

                entity.HasOne(d => d.Igra)
                    .WithMany(p => p.KorisnikIgre)
                    .HasForeignKey(d => d.IgraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__KorisnikI__IgraI__5629CD9C");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisnikIgre)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__KorisnikI__Koris__5535A963");
            });

            modelBuilder.Entity<KorisnikSocials>(entity =>
            {
                entity.Property(e => e.BattleNetName).IsUnicode(false);

                entity.Property(e => e.BattleNetProfilLink).IsUnicode(false);

                entity.Property(e => e.DiscordName).IsUnicode(false);

                entity.Property(e => e.EpicStoreName).IsUnicode(false);

                entity.Property(e => e.EpicStoreProfilLink).IsUnicode(false);

                entity.Property(e => e.NintendoName).IsUnicode(false);

                entity.Property(e => e.NintendoProfilLink).IsUnicode(false);

                entity.Property(e => e.OriginName).IsUnicode(false);

                entity.Property(e => e.OriginProfilLink).IsUnicode(false);

                entity.Property(e => e.Psnname)
                    .HasColumnName("PSNName")
                    .IsUnicode(false);

                entity.Property(e => e.PsnprofilLink)
                    .HasColumnName("PSNProfilLink")
                    .IsUnicode(false);

                entity.Property(e => e.SteamName).IsUnicode(false);

                entity.Property(e => e.SteamProfilLink).IsUnicode(false);

                entity.Property(e => e.XboxName).IsUnicode(false);

                entity.Property(e => e.XboxProfilLink).IsUnicode(false);

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisnikSocials)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__KorisnikS__Koris__59063A47");
            });

            modelBuilder.Entity<Platforme>(entity =>
            {
                entity.HasKey(e => e.PlatformId);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Skracenica)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Poruke>(entity =>
            {
                entity.HasKey(e => e.PorukaId);

                entity.Property(e => e.DatumKreiranja).HasColumnType("datetime");

                entity.Property(e => e.Tekst).IsRequired();

                entity.HasOne(d => d.PosiljalacNavigation)
                    .WithMany(p => p.PorukePosiljalacNavigation)
                    .HasForeignKey(d => d.Posiljalac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Poruke__Posiljal__05D8E0BE");

                entity.HasOne(d => d.PrimalacNavigation)
                    .WithMany(p => p.PorukePrimalacNavigation)
                    .HasForeignKey(d => d.Primalac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Poruke__Primalac__06CD04F7");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.Property(e => e.DatumEnd).HasColumnType("date");

                entity.Property(e => e.DatumStart).HasColumnType("date");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.SaleLink).IsUnicode(false);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Sale)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sale__StoreId__46E78A0C");
            });

            modelBuilder.Entity<SaleDetalji>(entity =>
            {
                entity.Property(e => e.StoreLink).IsUnicode(false);

                entity.HasOne(d => d.Igra)
                    .WithMany(p => p.SaleDetalji)
                    .HasForeignKey(d => d.IgraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SaleDetal__IgraI__4AB81AF0");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleDetalji)
                    .HasForeignKey(d => d.SaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SaleDetal__SaleI__49C3F6B7");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.Property(e => e.Link).IsUnicode(false);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Uloge>(entity =>
            {
                entity.HasKey(e => e.UlogaId);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Opis).HasColumnType("text");
            });

            modelBuilder.Entity<Zanrovi>(entity =>
            {
                entity.HasKey(e => e.ZanrId);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Skracenica)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
