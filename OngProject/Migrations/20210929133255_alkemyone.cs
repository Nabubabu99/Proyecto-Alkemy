using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OngProject.Migrations
{
    public partial class alkemyone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", maxLength: 65535, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FacebookURL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    InstagramURL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LinkedinURL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Phone = table.Column<int>(type: "int", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    WelcomeText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AboutUsText = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    FacebookURL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LinkedinURL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    InstagramURL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rols",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rols", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", maxLength: 65535, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", maxLength: 65535, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Slides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slides", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slides_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RolId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Rols_RolId",
                        column: x => x.RolId,
                        principalTable: "Rols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    NewsId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Content", "CreatedAt", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "Content1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Image1", false, "Name1" },
                    { 2, "Content2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Image2", false, "Name2" },
                    { 3, "Content3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Image3", false, "Name3" },
                    { 4, "Content4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Image4", false, "Name4" },
                    { 5, "Content5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Image5", false, "Name5" },
                    { 6, "Content6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Image6", false, "Name6" },
                    { 7, "Content7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Image7", false, "Name7" },
                    { 8, "Content8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Image8", false, "Name8" },
                    { 9, "Content9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Image9", false, "Name9" },
                    { 10, "Content10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Image10", false, "Name10" }
                });

            migrationBuilder.InsertData(
                table: "Rols",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Administrator" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Standard" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConfirmPassword", "CreatedAt", "Email", "FirstName", "IsDeleted", "LastName", "Password", "Photo", "RolId" },
                values: new object[,]
                {
                    { 1, "da2cb7f780b225403e5487ce7d40feaa0283f663ce05c7882df100110e8aae86", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email.1@example.com", "FirstName1", false, "LastName1", "da2cb7f780b225403e5487ce7d40feaa0283f663ce05c7882df100110e8aae86", null, 1 },
                    { 18, "7d46c9a102dd94082b0df0f06aa9b69256bec64f0c915ed34245235beaa673a1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email.18@example.com", "FirstName18", false, "LastName18", "7d46c9a102dd94082b0df0f06aa9b69256bec64f0c915ed34245235beaa673a1", null, 2 },
                    { 17, "c83de05a9ad9c1166c2b7a44ad2c306fced3a2bed18474432086f864abd04571", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email.17@example.com", "FirstName17", false, "LastName17", "c83de05a9ad9c1166c2b7a44ad2c306fced3a2bed18474432086f864abd04571", null, 2 },
                    { 16, "bb207afb4c102f15ae931f4b61c4ab41f91fec28a7eeca31f9be6032a9241a5e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email.16@example.com", "FirstName16", false, "LastName16", "bb207afb4c102f15ae931f4b61c4ab41f91fec28a7eeca31f9be6032a9241a5e", null, 2 },
                    { 15, "fefdbc0ad406198526298fa68616ab7590845ebb4b6610cd95b7d94fcb4a9327", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email.15@example.com", "FirstName15", false, "LastName15", "fefdbc0ad406198526298fa68616ab7590845ebb4b6610cd95b7d94fcb4a9327", null, 2 },
                    { 14, "433469d27acfdac401ca6dccfa117f862f88ab196db90351a2d3a455f6425562", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email.14@example.com", "FirstName14", false, "LastName14", "433469d27acfdac401ca6dccfa117f862f88ab196db90351a2d3a455f6425562", null, 2 },
                    { 13, "5a2713bbbaf02b5ccd0ddefea7585bd00ac6433bb75d5ac8e33d4af9b0505b6e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email.13@example.com", "FirstName13", false, "LastName13", "5a2713bbbaf02b5ccd0ddefea7585bd00ac6433bb75d5ac8e33d4af9b0505b6e", null, 2 },
                    { 12, "0d01e6313118ce3b9367556387930a3ebfdce61a629befacdf7afdad43245a8d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email.12@example.com", "FirstName12", false, "LastName12", "0d01e6313118ce3b9367556387930a3ebfdce61a629befacdf7afdad43245a8d", null, 2 },
                    { 11, "e4d79a53b370e1c11e4b10905fa6325c524a1e9beb6a4612dbf72460da0325b2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email.11@example.com", "FirstName11", false, "LastName11", "e4d79a53b370e1c11e4b10905fa6325c524a1e9beb6a4612dbf72460da0325b2", null, 2 },
                    { 10, "7562a64cdd0a4a1f7d9e77a50dcdc52ffe6a59db7d196293caa5e25a15a9e367", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email.10@example.com", "FirstName10", false, "LastName10", "7562a64cdd0a4a1f7d9e77a50dcdc52ffe6a59db7d196293caa5e25a15a9e367", null, 1 },
                    { 9, "343fb0969817815b1eb788c549b2a27601366b57ba383dc8ba46e39e64e5e6bf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email.9@example.com", "FirstName9", false, "LastName9", "343fb0969817815b1eb788c549b2a27601366b57ba383dc8ba46e39e64e5e6bf", null, 1 },
                    { 8, "ce62fe20d866e1e69de326a4f01b7a92b1ee4f1a3df9ae6698196178900b1723", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email.8@example.com", "FirstName8", false, "LastName8", "ce62fe20d866e1e69de326a4f01b7a92b1ee4f1a3df9ae6698196178900b1723", null, 1 },
                    { 7, "83f164ce80cfaa93ece1883784d17c4d88451f76b07456cdc8af3020847fb56b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email.7@example.com", "FirstName7", false, "LastName7", "83f164ce80cfaa93ece1883784d17c4d88451f76b07456cdc8af3020847fb56b", null, 1 },
                    { 6, "7c7bc4898dcac630e60c547a30157d0b4ebf38a43b0ccb830d1660025cbc501f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email.6@example.com", "FirstName6", false, "LastName6", "7c7bc4898dcac630e60c547a30157d0b4ebf38a43b0ccb830d1660025cbc501f", null, 1 },
                    { 5, "94137b5c6376f43518d5d158803e477fb33add3da1b4cf49bfa7ce57f09d4ad2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email.5@example.com", "FirstName5", false, "LastName5", "94137b5c6376f43518d5d158803e477fb33add3da1b4cf49bfa7ce57f09d4ad2", null, 1 },
                    { 4, "3e3c9fc79e9983f129e8c2868087a366de92423d0fc9cfe39b4b43b9715b0fe6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email.4@example.com", "FirstName4", false, "LastName4", "3e3c9fc79e9983f129e8c2868087a366de92423d0fc9cfe39b4b43b9715b0fe6", null, 1 },
                    { 3, "c02e7b0531c16cf9f95c1686fb9497c052aebe4ca9a3bf00fbc83c11245df53c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email.3@example.com", "FirstName3", false, "LastName3", "c02e7b0531c16cf9f95c1686fb9497c052aebe4ca9a3bf00fbc83c11245df53c", null, 1 },
                    { 2, "e95a7a5547e515340590caa15cbaa99914f594f1398e24e9cfd5207fb66dc0ff", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email.2@example.com", "FirstName2", false, "LastName2", "e95a7a5547e515340590caa15cbaa99914f594f1398e24e9cfd5207fb66dc0ff", null, 1 },
                    { 19, "462baa5d5c9865c59270375ad5bf4c5856372ddec84deefd9af2f15a03756142", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email.19@example.com", "FirstName19", false, "LastName19", "462baa5d5c9865c59270375ad5bf4c5856372ddec84deefd9af2f15a03756142", null, 2 },
                    { 20, "69ef1883caee50de909a3f11fda6937a483da453fd363467642982830570d2b8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email.20@example.com", "FirstName20", false, "LastName20", "69ef1883caee50de909a3f11fda6937a483da453fd363467642982830570d2b8", null, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_NewsId",
                table: "Comments",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_News_CategoryId",
                table: "News",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Slides_OrganizationId",
                table: "Slides",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RolId",
                table: "Users",
                column: "RolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Slides");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Rols");
        }
    }
}
