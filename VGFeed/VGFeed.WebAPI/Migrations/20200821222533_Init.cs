using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VGFeed.WebAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzave",
                columns: table => new
                {
                    DrzavaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzave", x => x.DrzavaId);
                });

            migrationBuilder.CreateTable(
                name: "Platforme",
                columns: table => new
                {
                    PlatformId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Skracenica = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Logo = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforme", x => x.PlatformId);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    StoreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Opis = table.Column<string>(type: "text", nullable: false),
                    Link = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.StoreId);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    UlogaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Opis = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.UlogaId);
                });

            migrationBuilder.CreateTable(
                name: "Zanrovi",
                columns: table => new
                {
                    ZanrId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Opis = table.Column<string>(type: "text", nullable: false),
                    Skracenica = table.Column<string>(unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zanrovi", x => x.ZanrId);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    SaleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(unicode: false, nullable: false),
                    DatumStart = table.Column<DateTime>(type: "date", nullable: false),
                    DatumEnd = table.Column<DateTime>(type: "date", nullable: false),
                    SaleLink = table.Column<string>(unicode: false, nullable: true),
                    StoreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.SaleId);
                    table.ForeignKey(
                        name: "FK__Sale__StoreId__46E78A0C",
                        column: x => x.StoreId,
                        principalTable: "Store",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    DatumRodjenja = table.Column<DateTime>(type: "date", nullable: false),
                    Spol = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    BrojTelefona = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Username = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    PasswordSalt = table.Column<string>(unicode: false, nullable: false),
                    PasswordHash = table.Column<string>(unicode: false, nullable: false),
                    DatumKreiranja = table.Column<DateTime>(type: "date", nullable: false),
                    Aktivan = table.Column<bool>(nullable: false),
                    DrzavaId = table.Column<int>(nullable: false),
                    UlogaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.KorisnikId);
                    table.ForeignKey(
                        name: "FK__Korisnici__Drzav__5165187F",
                        column: x => x.DrzavaId,
                        principalTable: "Drzave",
                        principalColumn: "DrzavaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Korisnici__Uloga__52593CB8",
                        column: x => x.UlogaId,
                        principalTable: "Uloge",
                        principalColumn: "UlogaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Igre",
                columns: table => new
                {
                    IgraId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    OriginalnaCijena = table.Column<double>(nullable: false),
                    TrenutnaCijena = table.Column<double>(nullable: false),
                    Opis = table.Column<string>(type: "text", nullable: false),
                    Developer = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Izdavac = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Multiplayer = table.Column<bool>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true),
                    SlikaThumb = table.Column<byte[]>(nullable: true),
                    PlatformId = table.Column<int>(nullable: false),
                    ZanrId = table.Column<int>(nullable: false),
                    DatumIzlaska = table.Column<DateTime>(type: "datetime", nullable: false),
                    MetacriticOcjena = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Igre", x => x.IgraId);
                    table.ForeignKey(
                        name: "FK__Igre__PlatformId__778AC167",
                        column: x => x.PlatformId,
                        principalTable: "Platforme",
                        principalColumn: "PlatformId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Igre__ZanrId__787EE5A0",
                        column: x => x.ZanrId,
                        principalTable: "Zanrovi",
                        principalColumn: "ZanrId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Donacije",
                columns: table => new
                {
                    DonacijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Token = table.Column<string>(nullable: false),
                    Kolicina = table.Column<double>(nullable: false),
                    DatumUplate = table.Column<DateTime>(type: "datetime", nullable: false),
                    KorisnikId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donacije", x => x.DonacijaId);
                    table.ForeignKey(
                        name: "FK__Donacije__Korisn__02FC7413",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikSocials",
                columns: table => new
                {
                    KorisnikSocialsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PSNName = table.Column<string>(unicode: false, nullable: true),
                    PSNProfilLink = table.Column<string>(unicode: false, nullable: true),
                    XboxName = table.Column<string>(unicode: false, nullable: true),
                    XboxProfilLink = table.Column<string>(unicode: false, nullable: true),
                    SteamName = table.Column<string>(unicode: false, nullable: true),
                    SteamProfilLink = table.Column<string>(unicode: false, nullable: true),
                    DiscordName = table.Column<string>(unicode: false, nullable: true),
                    EpicStoreName = table.Column<string>(unicode: false, nullable: true),
                    EpicStoreProfilLink = table.Column<string>(unicode: false, nullable: true),
                    OriginName = table.Column<string>(unicode: false, nullable: true),
                    OriginProfilLink = table.Column<string>(unicode: false, nullable: true),
                    BattleNetName = table.Column<string>(unicode: false, nullable: true),
                    BattleNetProfilLink = table.Column<string>(unicode: false, nullable: true),
                    NintendoName = table.Column<string>(unicode: false, nullable: true),
                    NintendoProfilLink = table.Column<string>(unicode: false, nullable: true),
                    KorisnikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikSocials", x => x.KorisnikSocialsId);
                    table.ForeignKey(
                        name: "FK__KorisnikS__Koris__59063A47",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Poruke",
                columns: table => new
                {
                    PorukaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tekst = table.Column<string>(nullable: false),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime", nullable: false),
                    StatusPoruke = table.Column<bool>(nullable: false),
                    Posiljalac = table.Column<int>(nullable: false),
                    Primalac = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poruke", x => x.PorukaId);
                    table.ForeignKey(
                        name: "FK__Poruke__Posiljal__05D8E0BE",
                        column: x => x.Posiljalac,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Poruke__Primalac__06CD04F7",
                        column: x => x.Primalac,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikIgre",
                columns: table => new
                {
                    KorisnikIgreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Igrao = table.Column<bool>(nullable: true),
                    Ocjena = table.Column<int>(nullable: true),
                    Zainteresiran = table.Column<bool>(nullable: true),
                    Recenzija = table.Column<string>(type: "text", nullable: true),
                    PosjedujeIgru = table.Column<bool>(nullable: true),
                    KorisnikId = table.Column<int>(nullable: false),
                    IgraId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikIgre", x => x.KorisnikIgreId);
                    table.ForeignKey(
                        name: "FK__KorisnikI__IgraI__5629CD9C",
                        column: x => x.IgraId,
                        principalTable: "Igre",
                        principalColumn: "IgraId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__KorisnikI__Koris__5535A963",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SaleDetalji",
                columns: table => new
                {
                    SaleDetaljiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Popust = table.Column<int>(nullable: false),
                    FizickaKopija = table.Column<bool>(nullable: false),
                    StoreLink = table.Column<string>(unicode: false, nullable: true),
                    Cijena = table.Column<double>(nullable: false),
                    SaleId = table.Column<int>(nullable: false),
                    IgraId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleDetalji", x => x.SaleDetaljiId);
                    table.ForeignKey(
                        name: "FK__SaleDetal__IgraI__4AB81AF0",
                        column: x => x.IgraId,
                        principalTable: "Igre",
                        principalColumn: "IgraId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__SaleDetal__SaleI__49C3F6B7",
                        column: x => x.SaleId,
                        principalTable: "Sale",
                        principalColumn: "SaleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Donacije_KorisnikId",
                table: "Donacije",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Igre_PlatformId",
                table: "Igre",
                column: "PlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_Igre_ZanrId",
                table: "Igre",
                column: "ZanrId");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnici_DrzavaId",
                table: "Korisnici",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnici_UlogaId",
                table: "Korisnici",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikIgre_IgraId",
                table: "KorisnikIgre",
                column: "IgraId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikIgre_KorisnikId",
                table: "KorisnikIgre",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikSocials_KorisnikId",
                table: "KorisnikSocials",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Poruke_Posiljalac",
                table: "Poruke",
                column: "Posiljalac");

            migrationBuilder.CreateIndex(
                name: "IX_Poruke_Primalac",
                table: "Poruke",
                column: "Primalac");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_StoreId",
                table: "Sale",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetalji_IgraId",
                table: "SaleDetalji",
                column: "IgraId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetalji_SaleId",
                table: "SaleDetalji",
                column: "SaleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donacije");

            migrationBuilder.DropTable(
                name: "KorisnikIgre");

            migrationBuilder.DropTable(
                name: "KorisnikSocials");

            migrationBuilder.DropTable(
                name: "Poruke");

            migrationBuilder.DropTable(
                name: "SaleDetalji");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "Igre");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Drzave");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Platforme");

            migrationBuilder.DropTable(
                name: "Zanrovi");

            migrationBuilder.DropTable(
                name: "Store");
        }
    }
}
