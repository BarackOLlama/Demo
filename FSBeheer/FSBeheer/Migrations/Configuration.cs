namespace FSBeheer.Migrations
{
    using FSBeheer.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FSBeheer.FSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(FSBeheer.FSContext context)
        {
            context.Answers.RemoveRange(context.Answers);
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.Answers', RESEED, 1)");
            context.Questions.RemoveRange(context.Questions);
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.Questions', RESEED, 1)");
            context.QuestionTypes.RemoveRange(context.QuestionTypes);
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.QuestionTypes', RESEED, 0)");
            context.Questionnaires.RemoveRange(context.Questionnaires);
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.Questionnaires', RESEED, 1)");
            context.Inspections.RemoveRange(context.Inspections);
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.Inspections', RESEED, 1)");
            context.Inspectors.RemoveRange(context.Inspectors);
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.Inspectors', RESEED, 1)");
            context.Accounts.RemoveRange(context.Accounts);
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.Accounts', RESEED, 0)");
            context.Roles.RemoveRange(context.Roles);
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.Roles', RESEED, 0)");

            context.SaveChanges();

            foreach(Role r in context.Roles)
            {
                System.Diagnostics.Debug.WriteLine("MSG: " + r.Content);
            }


            context.Roles.AddOrUpdate(
                new Role() { Content = "Salesmedewerker" },
                new Role() { Content = "Operationele medewerker" },
                new Role() { Content = "Inspecteur" }
            );

            context.QuestionTypes.AddOrUpdate(
                new QuestionType() { Name = "Open vraag" },
                new QuestionType() { Name = "Multiple Choice vraag" },
                new QuestionType() { Name = "Open Tabelvraag" },
                new QuestionType() { Name = "Multiple Choice Tabelvraag" }
            );

            context.SaveChanges();

            context.Accounts.AddOrUpdate(
                new Account()
                {
                    Username = "bkoevoets@gmail.com",
                    Password = "bartswachtwoord",
                    RoleId = 3
                },
                new Account()
                {
                    Username = "vnguyen@gmail.com",
                    Password = "phiswachtwoord",
                    RoleId = 3
                },
                new Account()
                {
                    Username = "clancaster@gmail.com",
                    Password = "cjswachtwoord",
                    RoleId = 3
                },
                new Account()
                {
                    Username = "earends@gmail.com",
                    Password = "evertswachtwoord",
                    RoleId = 3
                }
            );

            context.SaveChanges();

            context.Inspectors.AddOrUpdate(
                new Inspector()
                {
                    Name = "Bart Koevoets",
                    Address = "Bartsadres",
                    City = "Bartsstad",
                    Zipcode = "1234BK",
                    Email = "bkoevoets@gmail.com",
                    PhoneNumber = "0612345678",
                    CertificationDate = new DateTime(2018, 1, 1),
                    InvalidDate = new DateTime(2019, 1, 1),
                    BankNumber = "NL01INGB0123456789",
                    AccountId = 1
                },
                new Inspector()
                {
                    Name = "Phi Nguyen",
                    Address = "Phisadres",
                    City = "Phisstad",
                    Zipcode = "1234PN",
                    Email = "pnguyen@gmail.com",
                    PhoneNumber = "0612345678",
                    CertificationDate = new DateTime(2018, 1, 1),
                    InvalidDate = new DateTime(2019, 1, 1),
                    BankNumber = "NL01INGB0123456789",
                    AccountId = 2
                },
                new Inspector()
                {
                    Name = "Curwen Lancaster",
                    Address = "Curwensadres",
                    City = "Curwensstad",
                    Zipcode = "1234CL",
                    Email = "clancaster@gmail.com",
                    PhoneNumber = "0612345678",
                    CertificationDate = new DateTime(2018, 1, 1),
                    InvalidDate = new DateTime(2019, 1, 1),
                    BankNumber = "NL01INGB0123456789",
                    AccountId = 3
                },
                new Inspector()
                {
                    Name = "Evert Arends",
                    Address = "Evertsadres",
                    City = "Evertsstad",
                    Zipcode = "1234EA",
                    Email = "earends@gmail.com",
                    PhoneNumber = "0612345678",
                    CertificationDate = new DateTime(2018, 1, 1),
                    InvalidDate = new DateTime(2019, 1, 1),
                    BankNumber = "NL01INGB0123456789",
                    AccountId = 4
                }
            );

            context.Inspections.AddOrUpdate(
                new Inspection()
                {
                    State = "Ingepland",
                    Notes = "Minstens 4 inspecteurs"
                }
            );

            context.Questionnaires.AddOrUpdate(
                new Questionnaire()
                {
                    Name = "VragenlijstEersteInspectie",
                    Instructions = "Laat geen vragen leeg",
                    Version = 1,
                    Comments = "Dit is onze eerste inspectie, extra goed opletten!",
                    InspectionId = 1
                }
            );

            context.Questions.AddOrUpdate(
                new Question()
                {
                    Content = "Hoeveel man is er op het festival?",
                    Options = "100; 200; 500; 1000",
                    QuestionnaireId = 1,
                    QuestionTypeId = 2
                },
                new Question()
                {
                    Content = "Hoe groot is het percentage van roest op het podium?",
                    Options = "10%; 20%; 50%; 100%",
                    QuestionnaireId = 1,
                    QuestionTypeId = 2
                },
                new Question()
                {
                    Content = "Wat is de draaglast van de fundament van het podium?",
                    Options = "100kg; 200kg; 500kg; 1000kg",
                    QuestionnaireId = 1,
                    QuestionTypeId = 2
                },
                new Question()
                {
                    Content = "Hoeveel bars zijn er op het festival?",
                    Options = "5; 10; 20; 40",
                    QuestionnaireId = 1,
                    QuestionTypeId = 2
                }
            );

            context.Answers.AddOrUpdate(
                new Answer()
                {
                    Content = "200",
                    QuestionId = 1,
                    InspectorId = 1
                },
                new Answer()
                {
                    Content = "100",
                    QuestionId = 1,
                    InspectorId = 2
                },
                new Answer()
                {
                    Content = "200",
                    QuestionId = 1,
                    InspectorId = 3
                },
                new Answer()
                {
                    Content = "500",
                    QuestionId = 1,
                    InspectorId = 4
                },
                new Answer()
                {
                    Content = "10%",
                    QuestionId = 2,
                    InspectorId = 1
                },
                new Answer()
                {
                    Content = "10%",
                    QuestionId = 2,
                    InspectorId = 2
                },
                new Answer()
                {
                    Content = "10%",
                    QuestionId = 2,
                    InspectorId = 3
                },
                new Answer()
                {
                    Content = "20%",
                    QuestionId = 2,
                    InspectorId = 4
                },
                new Answer()
                {
                    Content = "200kg",
                    QuestionId = 3,
                    InspectorId = 1
                },
                new Answer()
                {
                    Content = "200kg",
                    QuestionId = 3,
                    InspectorId = 2
                },
                new Answer()
                {
                    Content = "200kg",
                    QuestionId = 3,
                    InspectorId = 3
                },
                new Answer()
                {
                    Content = "200kg",
                    QuestionId = 3,
                    InspectorId = 4
                },
                new Answer()
                {
                    Content = "20",
                    QuestionId = 4,
                    InspectorId = 1
                },
                new Answer()
                {
                    Content = "10",
                    QuestionId = 4,
                    InspectorId = 2
                },
                new Answer()
                {
                    Content = "40",
                    QuestionId = 4,
                    InspectorId = 3
                },
                new Answer()
                {
                    Content = "20",
                    QuestionId = 4,
                    InspectorId = 4
                }
            );

            context.SaveChanges();
        }
    }
}
