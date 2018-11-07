namespace FSBeheer
{
    using FSBeheer.Model;
    using System.Data.Entity;

    public partial class FSContext : DbContext
    {
        public FSContext()
            : base("name=FSDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FSContext, Migrations.Configuration>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<FSContext>());
        }

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Questionnaire> Questionnaires { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionType> QuestionTypes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Inspection> Inspections { get; set; }
        public virtual DbSet<Inspector> Inspectors { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
