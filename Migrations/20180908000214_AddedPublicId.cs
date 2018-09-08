using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.API.Migrations
{
    /// <summary>
    /// PublicId for cloud image hosting migration.
    /// </summary>
    public partial class AddedPublicId : Migration
    {
        /// <summary>
        /// Adds PublicId column to Photos table
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PublicId",
                table: "Photos",
                nullable: true);
        }

        /// <summary>
        /// Drops PublicId column from photos table.
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicId",
                table: "Photos");
        }
    }
}
