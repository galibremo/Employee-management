namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateunique : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblEmployees", "EmployeeCode", c => c.String(nullable: false, maxLength: 10));
            CreateIndex("dbo.tblEmployees", "EmployeeCode", unique: true, name: "EmployeeCode");
        }
        
        public override void Down()
        {
            DropIndex("dbo.tblEmployees", "EmployeeCode");
            AlterColumn("dbo.tblEmployees", "EmployeeCode", c => c.String(nullable: false));
        }
    }
}
