namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblEmployeeAttendances",
                c => new
                    {
                        EmployeeId = c.String(nullable: false, maxLength: 128),
                        AttendanceDate = c.DateTime(nullable: false),
                        IsPresent = c.Int(nullable: false),
                        IsAbsent = c.Int(nullable: false),
                        IsOffday = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.tblEmployees",
                c => new
                    {
                        EmployeeId = c.String(nullable: false, maxLength: 128),
                        EmployeeName = c.String(nullable: false),
                        EmployeeCode = c.String(nullable: false),
                        EmployeeSalary = c.Int(nullable: false),
                        SupervisorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblEmployees");
            DropTable("dbo.tblEmployeeAttendances");
        }
    }
}
