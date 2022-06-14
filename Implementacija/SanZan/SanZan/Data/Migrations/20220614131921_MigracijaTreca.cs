using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SanZan.Data.Migrations
{
    public partial class MigracijaTreca : Migration
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
                    IznosUplate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BezgotovinskaUplate", x => x.IDUplate);
                });

            migrationBuilder.CreateTable(
                name: "GotovinskaUplata",
                columns: table => new
                {
                    IDUplate = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDKlijenta = table.Column<int>(type: "int", nullable: false),
                    IDDjelatnika = table.Column<int>(type: "int", nullable: false),
                    IznosUplate = table.Column<double>(type: "float", nullable: false)
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
                    Pitanje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Odgovor = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    IznosNaKartici = table.Column<double>(type: "float", nullable: false),
                    DatumIzdavanjaKartice = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    Marker = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KonkretniStatus", x => x.IDStatus);
                });

            migrationBuilder.CreateTable(
                name: "Lokacija",
                columns: table => new
                {
                    IDLokacije = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kanton = table.Column<int>(type: "int", nullable: false),
                    Grad = table.Column<int>(type: "int", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokacija", x => x.IDLokacije);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    IDTaga = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Djelatnost = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.IDTaga);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    IDKorisnika = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lozinka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDKartice = table.Column<int>(type: "int", nullable: false),
                    BrojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LokacijaId = table.Column<int>(type: "int", nullable: false),
                    NazivRadnje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipDjelatnika = table.Column<int>(type: "int", nullable: false),
                    Djelatnost = table.Column<int>(type: "int", nullable: false),
                    Banovan = table.Column<bool>(type: "bit", nullable: false),
                    IDAdministratora = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.IDKorisnika);
                    table.ForeignKey(
                        name: "FK_Korisnik_Lokacija_LokacijaId",
                        column: x => x.LokacijaId,
                        principalTable: "Lokacija",
                        principalColumn: "IDLokacije",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Oglas",
                columns: table => new
                {
                    IDOglasa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDDjelatnika = table.Column<int>(type: "int", nullable: false),
                    NazivShopa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LokacijaID = table.Column<int>(type: "int", nullable: false),
                    Ocjena = table.Column<double>(type: "float", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oglas", x => x.IDOglasa);
                    table.ForeignKey(
                        name: "FK_Oglas_Lokacija_LokacijaID",
                        column: x => x.LokacijaID,
                        principalTable: "Lokacija",
                        principalColumn: "IDLokacije",
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
                name: "Poruka",
                columns: table => new
                {
                    IDPoruke = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPrimaoca = table.Column<int>(type: "int", nullable: false),
                    PrimaocIDKorisnika = table.Column<int>(type: "int", nullable: true),
                    IDPosiljaoca = table.Column<int>(type: "int", nullable: false),
                    PosiljaocIDKorisnika = table.Column<int>(type: "int", nullable: true),
                    Vrijeme = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sadrzaj = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poruka", x => x.IDPoruke);
                    table.ForeignKey(
                        name: "FK_Poruka_Korisnik_PosiljaocIDKorisnika",
                        column: x => x.PosiljaocIDKorisnika,
                        principalTable: "Korisnik",
                        principalColumn: "IDKorisnika",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Poruka_Korisnik_PrimaocIDKorisnika",
                        column: x => x.PrimaocIDKorisnika,
                        principalTable: "Korisnik",
                        principalColumn: "IDKorisnika",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prijava",
                columns: table => new
                {
                    IDPrijave = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPrijavljenog = table.Column<int>(type: "int", nullable: false),
                    PrijavljeniIDKorisnika = table.Column<int>(type: "int", nullable: true),
                    IDZalbenika = table.Column<int>(type: "int", nullable: false),
                    ZalbenikIDKorisnika = table.Column<int>(type: "int", nullable: true),
                    TipPrijave = table.Column<int>(type: "int", nullable: false),
                    IDAdministratora = table.Column<int>(type: "int", nullable: false),
                    AdministratorIDKorisnika = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prijava", x => x.IDPrijave);
                    table.ForeignKey(
                        name: "FK_Prijava_Korisnik_AdministratorIDKorisnika",
                        column: x => x.AdministratorIDKorisnika,
                        principalTable: "Korisnik",
                        principalColumn: "IDKorisnika",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prijava_Korisnik_PrijavljeniIDKorisnika",
                        column: x => x.PrijavljeniIDKorisnika,
                        principalTable: "Korisnik",
                        principalColumn: "IDKorisnika",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prijava_Korisnik_ZalbenikIDKorisnika",
                        column: x => x.ZalbenikIDKorisnika,
                        principalTable: "Korisnik",
                        principalColumn: "IDKorisnika",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recenzija",
                columns: table => new
                {
                    IDRecenzije = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDRecenzenta = table.Column<int>(type: "int", nullable: false),
                    RecenzentIDKorisnika = table.Column<int>(type: "int", nullable: true),
                    IDjelatnika = table.Column<int>(type: "int", nullable: false),
                    DjelatnikIDKorisnika = table.Column<int>(type: "int", nullable: true),
                    Vrijeme = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ocjena = table.Column<int>(type: "int", nullable: false),
                    Komentar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzija", x => x.IDRecenzije);
                    table.ForeignKey(
                        name: "FK_Recenzija_Korisnik_DjelatnikIDKorisnika",
                        column: x => x.DjelatnikIDKorisnika,
                        principalTable: "Korisnik",
                        principalColumn: "IDKorisnika",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recenzija_Korisnik_RecenzentIDKorisnika",
                        column: x => x.RecenzentIDKorisnika,
                        principalTable: "Korisnik",
                        principalColumn: "IDKorisnika",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Statistika",
                columns: table => new
                {
                    IDDjelatnika = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DjelatnikIDKorisnika = table.Column<int>(type: "int", nullable: true),
                    BrojUspjesnihSaradnji = table.Column<int>(type: "int", nullable: false),
                    BrojPosjeta = table.Column<int>(type: "int", nullable: false),
                    BrojPrijava = table.Column<int>(type: "int", nullable: false),
                    BrojUcesca = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistika", x => x.IDDjelatnika);
                    table.ForeignKey(
                        name: "FK_Statistika_Korisnik_DjelatnikIDKorisnika",
                        column: x => x.DjelatnikIDKorisnika,
                        principalTable: "Korisnik",
                        principalColumn: "IDKorisnika",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zahtjev",
                columns: table => new
                {
                    IDZahtjeva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDKlijenta = table.Column<int>(type: "int", nullable: false),
                    VrijemeZahtjeva = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Djelatnost = table.Column<int>(type: "int", nullable: false),
                    IDLokacija = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zahtjev", x => x.IDZahtjeva);
                    table.ForeignKey(
                        name: "FK_Zahtjev_Korisnik_IDKlijenta",
                        column: x => x.IDKlijenta,
                        principalTable: "Korisnik",
                        principalColumn: "IDKorisnika",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zahtjev_Lokacija_IDLokacija",
                        column: x => x.IDLokacija,
                        principalTable: "Lokacija",
                        principalColumn: "IDLokacije",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModeratorOglasi",
                columns: table => new
                {
                    IDModeratorOglasi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDModeratora = table.Column<int>(type: "int", nullable: true),
                    IDOglasa = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeratorOglasi", x => x.IDModeratorOglasi);
                    table.ForeignKey(
                        name: "FK_ModeratorOglasi_Korisnik_IDModeratora",
                        column: x => x.IDModeratora,
                        principalTable: "Korisnik",
                        principalColumn: "IDKorisnika",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ModeratorOglasi_Oglas_IDOglasa",
                        column: x => x.IDOglasa,
                        principalTable: "Oglas",
                        principalColumn: "IDOglasa",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IX_Korisnik_LokacijaId",
                table: "Korisnik",
                column: "LokacijaId");

            migrationBuilder.CreateIndex(
                name: "IX_ModeratorOglasi_IDModeratora",
                table: "ModeratorOglasi",
                column: "IDModeratora");

            migrationBuilder.CreateIndex(
                name: "IX_ModeratorOglasi_IDOglasa",
                table: "ModeratorOglasi",
                column: "IDOglasa");

            migrationBuilder.CreateIndex(
                name: "IX_Oglas_LokacijaID",
                table: "Oglas",
                column: "LokacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Poruka_PosiljaocIDKorisnika",
                table: "Poruka",
                column: "PosiljaocIDKorisnika");

            migrationBuilder.CreateIndex(
                name: "IX_Poruka_PrimaocIDKorisnika",
                table: "Poruka",
                column: "PrimaocIDKorisnika");

            migrationBuilder.CreateIndex(
                name: "IX_Prijava_AdministratorIDKorisnika",
                table: "Prijava",
                column: "AdministratorIDKorisnika");

            migrationBuilder.CreateIndex(
                name: "IX_Prijava_PrijavljeniIDKorisnika",
                table: "Prijava",
                column: "PrijavljeniIDKorisnika");

            migrationBuilder.CreateIndex(
                name: "IX_Prijava_ZalbenikIDKorisnika",
                table: "Prijava",
                column: "ZalbenikIDKorisnika");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_DjelatnikIDKorisnika",
                table: "Recenzija",
                column: "DjelatnikIDKorisnika");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_RecenzentIDKorisnika",
                table: "Recenzija",
                column: "RecenzentIDKorisnika");

            migrationBuilder.CreateIndex(
                name: "IX_Statistika_DjelatnikIDKorisnika",
                table: "Statistika",
                column: "DjelatnikIDKorisnika");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjev_IDKlijenta",
                table: "Zahtjev",
                column: "IDKlijenta");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjev_IDLokacija",
                table: "Zahtjev",
                column: "IDLokacija");

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
                name: "GotovinskaUplata");

            migrationBuilder.DropTable(
                name: "InfoPitanje");

            migrationBuilder.DropTable(
                name: "Kartica");

            migrationBuilder.DropTable(
                name: "KonkretniStatus");

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
                name: "Oglas");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Zahtjev");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Lokacija");
        }
    }
}
