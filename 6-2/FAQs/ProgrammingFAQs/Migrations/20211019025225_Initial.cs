using Microsoft.EntityFrameworkCore.Migrations;

namespace FAQs.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    CategoryID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    TopicID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.TopicID);
                });

            migrationBuilder.CreateTable(
                name: "FAQs",
                columns: table => new
                {
                    FAQID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<string>(nullable: true),
                    TopicID = table.Column<string>(nullable: true),
                    Question = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQs", x => x.FAQID);
                    table.ForeignKey(
                        name: "FK_FAQs_Categorys_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categorys",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FAQs_Topics_TopicID",
                        column: x => x.TopicID,
                        principalTable: "Topics",
                        principalColumn: "TopicID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { "general", "General" },
                    { "history", "History" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicID", "Name" },
                values: new object[,]
                {
                    { "bootstrap", "Bootstrap" },
                    { "csharp", "C#" },
                    { "javascript", "JavaScript" }
                });

            migrationBuilder.InsertData(
                table: "FAQs",
                columns: new[] { "FAQID", "Answer", "CategoryID", "Question", "TopicID" },
                values: new object[,]
                {
                    { 3, "Yes, Bootstrap is a free and open-source CSS framework.", "general", "Is bootstrap free?", "bootstrap" },
                    { 4, "Bootstrap was created at Twitter in mid-2010 by Mark Otto and Jacob Thornton.", "history", "When was bootstrap created?", "bootstrap" },
                    { 1, "C# was designed by Anders Hejlsberg from Microsoft in 2000.", "history", "Who designed the C# programming language?", "csharp" },
                    { 2, "No, the C# language does not allow for global variables or functions.", "general", "Does C# allow global variables?", "csharp" },
                    { 5, "Brendan Eich created JavaScript in 1995.", "general", "Who created the JavaScript programming language?", "javascript" },
                    { 6, "JavaScript was originally called Mocha.", "history", "What was JavaScript originally called?", "javascript" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_CategoryID",
                table: "FAQs",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_TopicID",
                table: "FAQs",
                column: "TopicID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FAQs");

            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
