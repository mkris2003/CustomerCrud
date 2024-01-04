using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class InitalDataInsertCustomerDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([FirstName],[LastName],[Email],[CreateAt],[LastUpdated])\r\nVALUES('Test1FirstName','Test1LastName','Test1@gmail.com', GETUTCDATE(),GETUTCDATE() )");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([FirstName],[LastName],[Email],[CreateAt],[LastUpdated])\r\nVALUES('Test2FirstName','Test2LastName','Test2@gmail.com', GETUTCDATE(),GETUTCDATE() )");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([FirstName],[LastName],[Email],[CreateAt],[LastUpdated])\r\nVALUES('Test3FirstName','Test3LastName','Test3@gmail.com', GETUTCDATE(),GETUTCDATE() )");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([FirstName],[LastName],[Email],[CreateAt],[LastUpdated])\r\nVALUES('Test4FirstName','Test4LastName','Test4@gmail.com', GETUTCDATE(),GETUTCDATE() )");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([FirstName],[LastName],[Email],[CreateAt],[LastUpdated])\r\nVALUES('Test5FirstName','Test5LastName','Test5@gmail.com', GETUTCDATE(),GETUTCDATE() )");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([FirstName],[LastName],[Email],[CreateAt],[LastUpdated])\r\nVALUES('Test6FirstName','Test6LastName','Test6@gmail.com', GETUTCDATE(),GETUTCDATE() )");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([FirstName],[LastName],[Email],[CreateAt],[LastUpdated])\r\nVALUES('Test7FirstName','Test7LastName','Test7@gmail.com', GETUTCDATE(),GETUTCDATE() )");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([FirstName],[LastName],[Email],[CreateAt],[LastUpdated])\r\nVALUES('Test81FirstName','Test8LastName','Test8@gmail.com', GETUTCDATE(),GETUTCDATE() )");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([FirstName],[LastName],[Email],[CreateAt],[LastUpdated])\r\nVALUES('Test9FirstName','Test9LastName','Test9@gmail.com', GETUTCDATE(),GETUTCDATE() )");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([FirstName],[LastName],[Email],[CreateAt],[LastUpdated])\r\nVALUES('Test10FirstName','Test10LastName','Test10@gmail.com', GETUTCDATE(),GETUTCDATE() )");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([FirstName],[LastName],[Email],[CreateAt],[LastUpdated])\r\nVALUES('Test11FirstName','Test11LastName','Test11@gmail.com', GETUTCDATE(),GETUTCDATE() )");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([FirstName],[LastName],[Email],[CreateAt],[LastUpdated])\r\nVALUES('Test12FirstName','Test12LastName','Test12@gmail.com', GETUTCDATE(),GETUTCDATE() )");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([FirstName],[LastName],[Email],[CreateAt],[LastUpdated])\r\nVALUES('Test13FirstName','Test13LastName','Test13@gmail.com', GETUTCDATE(),GETUTCDATE() )");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([FirstName],[LastName],[Email],[CreateAt],[LastUpdated])\r\nVALUES('Test14FirstName','Test14LastName','Test14@gmail.com', GETUTCDATE(),GETUTCDATE() )");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([FirstName],[LastName],[Email],[CreateAt],[LastUpdated])\r\nVALUES('Test15FirstName','Test15LastName','Test15@gmail.com', GETUTCDATE(),GETUTCDATE() )");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([FirstName],[LastName],[Email],[CreateAt],[LastUpdated])\r\nVALUES('Test16FirstName','Test16LastName','Test16@gmail.com', GETUTCDATE(),GETUTCDATE() )");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([FirstName],[LastName],[Email],[CreateAt],[LastUpdated])\r\nVALUES('Test17FirstName','Test17LastName','Test17@gmail.com', GETUTCDATE(),GETUTCDATE() )");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([FirstName],[LastName],[Email],[CreateAt],[LastUpdated])\r\nVALUES('Test18FirstName','Test18LastName','Test18@gmail.com', GETUTCDATE(),GETUTCDATE() )");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([FirstName],[LastName],[Email],[CreateAt],[LastUpdated])\r\nVALUES('Test19FirstName','Test19LastName','Test19@gmail.com', GETUTCDATE(),GETUTCDATE() )");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([FirstName],[LastName],[Email],[CreateAt],[LastUpdated])\r\nVALUES('Test20FirstName','Test20LastName','Test20@gmail.com', GETUTCDATE(),GETUTCDATE() )");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([FirstName],[LastName],[Email],[CreateAt],[LastUpdated])\r\nVALUES('Test21FirstName','Test21LastName','Test21@gmail.com', GETUTCDATE(),GETUTCDATE() )");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
