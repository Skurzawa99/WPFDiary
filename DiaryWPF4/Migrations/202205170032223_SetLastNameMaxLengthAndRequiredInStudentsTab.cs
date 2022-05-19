namespace DiaryWPF4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetLastNameMaxLengthAndRequiredInStudentsTab : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "LastName", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "LastName", c => c.String());
        }
    }
}
