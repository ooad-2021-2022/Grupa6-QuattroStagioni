using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SanZan.Data.Migrations
{
    public partial class PrvaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BezgotovinskaUplate",
                columns: table => new
                {
                    IDUplate = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDKarticeKlijenta = table.Column<int>(type: "int", nullable: false),
                    IDKarticeDjelatnika = table.Column<int>(type: "int", nullable: false),
                    iznosUplate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BezgotovinskaUplate", x => x.IDUplate);
                });

            migrationBuilder.CreateTable(
                name: "GlobalnaStatistika",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brojKorisnika = table.Column<int>(type: "int", nullable: false),
                    brojOglasa = table.Column<int>(type: "int", nullable: false),
                    brojBanovanihKorisnika = table.Column<int>(type: "int", nullable: false),
                    brojUspjesnihSaradnji = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalnaStatistika", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GotovinskaUplata",
                columns: table => new
                {
                    IDUplate = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDKlijenta = table.Column<int>(type: "int", nullable: false),
                    IDDjelatnika = table.Column<int>(type: "int", nullable: false),
                    iznosUplate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GotovinskaUplata", x => x.IDUplate);
                });

            migrationBuilder.CreateTable(
                name: "InfoPitanje",
                columns: table => new
                {
                    IDPitanja = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pitanje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    odgovor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoPitanje", x => x.IDPitanja);
                });

            migrationBuilder.CreateTable(
                name: "Kartica",
                columns: table => new
                {
                    IDKartice = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDVlasnikaKartice = table.Column<int>(type: "int", nullable: false),
                    iznosNaKartici = table.Column<double>(type: "float", nullable: false),
                    datumIzdavanjaKartice = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kartica", x => x.IDKartice);
                });

            migrationBuilder.CreateTable(
                name: "KonkretniStatus",
                columns: table => new
                {
                    IDStatus = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marker = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KonkretniStatus", x => x.IDStatus);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    IDKorisnika = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    korisnickoIme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lozinka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDKartice = table.Column<int>(type: "int", nullable: false),
                    brojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lokacija = table.Column<int>(type: "int", nullable: false),
                    nazivRadnje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipDjelatnika = table.Column<int>(type: "int", nullable: false),
                    djelatnost = table.Column<int>(type: "int", nullable: false),
                    banovan = table.Column<bool>(type: "bit", nullable: false),
                    IDAdministratora = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.IDKorisnika);
                });

            migrationBuilder.CreateTable(
                name: "Lokacija",
                columns: table => new
                {
                    IDLokacije = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kanton = table.Column<int>(type: "int", nullable: false),
                    grad = table.Column<int>(type: "int", nullable: false),
                    adresa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokacija", x => x.IDLokacije);
                });

            migrationBuilder.CreateTable(
                name: "Oglas",
                columns: table => new
                {
                    IDOglasa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDDjelatnika = table.Column<int>(type: "int", nullable: false),
                    nazivShopa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lokacija = table.Column<int>(type: "int", nullable: false),
                    ocjena = table.Column<double>(type: "float", nullable: false),
                    opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oglas", x => x.IDOglasa);
                });

            migrationBuilder.CreateTable(
                name: "Poruka",
                columns: table => new
                {
                    IDPoruke = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPrimaoca = table.Column<int>(type: "int", nullable: false),
                    IDPosiljaoca = table.Column<int>(type: "int", nullable: false),
                    vrijeme = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sadrzaj = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poruka", x => x.IDPoruke);
                });

            migrationBuilder.CreateTable(
                name: "Prijava",
                columns: table => new
                {
                    IDPrijave = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPrijavljenog = table.Column<int>(type: "int", nullable: false),
                    IDZalbenika = table.Column<int>(type: "int", nullable: false),
                    tipPrijave = table.Column<int>(type: "int", nullable: false),
                    IDAdministratora = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prijava", x => x.IDPrijave);
                });

            migrationBuilder.CreateTable(
                name: "Recenzija",
                columns: table => new
                {
                    IDRecenzije = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDRecenzenta = table.Column<int>(type: "int", nullable: false),
                    IDjelatnika = table.Column<int>(type: "int", nullable: false),
                    vrijeme = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ocjena = table.Column<int>(type: "int", nullable: false),
                    komentar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzija", x => x.IDRecenzije);
                });

            migrationBuilder.CreateTable(
                name: "Statistika",
                columns: table => new
                {
                    IDDjelatnika = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brojUspjesnihSaradnji = table.Column<int>(type: "int", nullable: false),
                    brojPosjeta = table.Column<int>(type: "int", nullable: false),
                    brojPrijava = table.Column<int>(type: "int", nullable: false),
                    brojUcesca = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistika", x => x.IDDjelatnika);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    IDTaga = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    djelatnost = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.IDTaga);
                });

            migrationBuilder.CreateTable(
                name: "Zahtjev",
                columns: table => new
                {
                    IDZahtjeva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDKlijenta = table.Column<int>(type: "int", nullable: false),
                    vrijemeZahtjeva = table.Column<DateTime>(type: "datetime2", nullable: false),
                    djelatnost = table.Column<int>(type: "int", nullable: false),
                    lokacija = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zahtjev", x => x.IDZahtjeva);
                });

            migrationBuilder.CreateTable(
                name: "ModeratorOglasi",
                columns: table => new
                {
                    IDModeratorOglasi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDModeratora = table.Column<int>(type: "int", nullable: false),
                    IDOglasa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeratorOglasi", x => x.IDModeratorOglasi);
                    table.ForeignKey(
                        name: "FK_ModeratorOglasi_Korisnik_IDModeratora",
                        column: x => x.IDModeratora,
                        principalTable: "Korisnik",
                        principalColumn: "IDKorisnika",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModeratorOglasi_Oglas_IDOglasa",
                        column: x => x.IDOglasa,
                        principalTable: "Oglas",
                        principalColumn: "IDOglasa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DjelatnikTagovi",
                columns: table => new
                {
                    IDDjelatnikTagovi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDDjelatnika = table.Column<int>(type: "int", nullable: false),
                    IDTaga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DjelatnikTagovi", x => x.IDDjelatnikTagovi);
                    table.ForeignKey(
                        name: "FK_DjelatnikTagovi_Korisnik_IDDjelatnika",
                        column: x => x.IDDjelatnika,
                        principalTable: "Korisnik",
                        principalColumn: "IDKorisnika",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DjelatnikTagovi_Tag_IDTaga",
                        column: x => x.IDTaga,
                        principalTable: "Tag",
                        principalColumn: "IDTaga",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZahtjevTagovi",
                columns: table => new
                {
                    IDZahtjevTagovi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDZahtjev = table.Column<int>(type: "int", nullable: false),
                    IDTaga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZahtjevTagovi", x => x.IDZahtjevTagovi);
                    table.ForeignKey(
                        name: "FK_ZahtjevTagovi_Tag_IDTaga",
                        column: x => x.IDTaga,
                        principalTable: "Tag",
                        principalColumn: "IDTaga",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZahtjevTagovi_Zahtjev_IDZahtjev",
                        column: x => x.IDZahtjev,
                        principalTable: "Zahtjev",
                        principalColumn: "IDZahtjeva",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DjelatnikTagovi_IDDjelatnika",
                table: "DjelatnikTagovi",
                column: "IDDjelatnika");

            migrationBuilder.CreateIndex(
                name: "IX_DjelatnikTagovi_IDTaga",
                table: "DjelatnikTagovi",
                column: "IDTaga");

            migrationBuilder.CreateIndex(
                name: "IX_ModeratorOglasi_IDModeratora",
                table: "ModeratorOglasi",
                column: "IDModeratora");

            migrationBuilder.CreateIndex(
                name: "IX_ModeratorOglasi_IDOglasa",
                table: "ModeratorOglasi",
                column: "IDOglasa");

            migrationBuilder.CreateIndex(
                name: "IX_ZahtjevTagovi_IDTaga",
                table: "ZahtjevTagovi",
                column: "IDTaga");

            migrationBuilder.CreateIndex(
                name: "IX_ZahtjevTagovi_IDZahtjev",
                table: "ZahtjevTagovi",
                column: "IDZahtjev");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BezgotovinskaUplate");

            migrationBuilder.DropTable(
                name: "DjelatnikTagovi");

            migrationBuilder.DropTable(
                name: "GlobalnaStatistika");

            migrationBuilder.DropTable(
                name: "GotovinskaUplata");

            migrationBuilder.DropTable(
                name: "InfoPitanje");

            migrationBuilder.DropTable(
                name: "Kartica");

            migrationBuilder.DropTable(
                name: "KonkretniStatus");

            migrationBuilder.DropTable(
                name: "Lokacija");

            migrationBuilder.DropTable(
                name: "ModeratorOglasi");

            migrationBuilder.DropTable(
                name: "Poruka");

            migrationBuilder.DropTable(
                name: "Prijava");

            migrationBuilder.DropTable(
                name: "Recenzija");

            migrationBuilder.DropTable(
                name: "Statistika");

            migrationBuilder.DropTable(
                name: "ZahtjevTagovi");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Oglas");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Zahtjev");
        }
    }
}
