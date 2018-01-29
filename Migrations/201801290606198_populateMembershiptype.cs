namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("insert into MembersShipType (id,signupfee,duration,discountrate) values(1,0,0,0)");
            Sql("insert into MembershipType (id,signupfee,duration,discountrate) values(2,30,10,0)");
        }
        
        public override void Down()
        {
        }
    }
}
