using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueueSettings.Migrations
{
    /// <inheritdoc />
    public partial class AddQueueSettingsToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "queueEmployeeSettings",
                columns: table => new
                {
                    QueueGuid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QueueName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isSharedQueue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_queueEmployeeSettings", x => x.QueueGuid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "queueEmployeeSettings");
        }
    }
}
