namespace LorventWeekendTask.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LorventWeekendTask.DAL.AreaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LorventWeekendTask.DAL.AreaContext context)
        {
               context.User.AddOrUpdate(x => x.Id,
        new Areas.Admin.Models.User() { Id = 1, Username = "RenardGris",Password="test123" }    
        );
               context.NewsAdds.AddOrUpdate(x => x.Id,
        new Areas.Admin.Models.NewsAdd() { Id = 1, Title= "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",Category="Yoga",DateTime= "24-09-2016" }, 
        new Areas.Admin.Models.NewsAdd() { Id = 2, Title= "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",Category="Yoga",DateTime= "24-09-2016" },
        new Areas.Admin.Models.NewsAdd() { Id = 3, Title = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", Category = "Yoga", DateTime = "24-09-2016" },
        new Areas.Admin.Models.NewsAdd() { Id = 4, Title = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", Category = "Yoga", DateTime = "24-09-2016" },
        new Areas.Admin.Models.NewsAdd() { Id = 5, Title = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", Category = "Yoga", DateTime = "24-09-2016" }
        );    
        }
    }
}
