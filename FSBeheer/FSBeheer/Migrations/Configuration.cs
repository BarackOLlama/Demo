namespace FSBeheer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using FSBeheer.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<FSBeheer.FSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(FSBeheer.FSContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Roles.RemoveRange(context.Roles);
            context.QuestionTypes.RemoveRange(context.QuestionTypes);
            context.Accounts.RemoveRange(context.Accounts);
            context.Inspectors.RemoveRange(context.Inspectors);
            context.Inspections.RemoveRange(context.Inspections);
            context.Questionnaires.RemoveRange(context.Questionnaires);
            context.Questions.RemoveRange(context.Questions);
            context.Answers.RemoveRange(context.Answers);


            context.Roles.AddOrUpdate(
                new Role() { Content = "Salesmedewerker"},
                new Role() { Content = "Operationele medewerker"},
                new Role() { Content = "Inspecteur"}
            );

            context.QuestionTypes.AddOrUpdate(
                new QuestionType() { Name = "Open vraag" },
                new QuestionType() { Name = "Multiple Choice vraag" },
                new QuestionType() { Name = "Open Tabelvraag" },
                new QuestionType() { Name = "Multiple Choice Tabelvraag" }
            );

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
                    BankNumber = "NL01INGB0123456789"
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
                    BankNumber = "NL01INGB0123456789"
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
                    BankNumber = "NL01INGB0123456789"
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
                    BankNumber = "NL01INGB0123456789"
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
                new Question() {
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

            //if (context.Categories.Count() == 0)
            //{
            //    context.Categories.AddOrUpdate(
            //        new Category() { Name = "Syntax" },
            //        new Category() { Name = "Structuur" },
            //        new Category() { Name = "Java" },
            //        new Category() { Name = "Python" },
            //        new Category() { Name = "C#" }
            //    );
            //}

            //context.Answers.RemoveRange(context.Answers);
            //context.Questions.RemoveRange(context.Questions);

            //Question q1;
            //Question q2;
            //Question q3;
            //Question q4;
            //Question q5;

            //context.Questions.AddOrUpdate(
            //    q1 = new Question()
            //    {
            //        Content = "Hoe is x?",
            //        CategoryId = 2,
            //        Answers = {
            //            new Answer(){ Content = "A", Correct = false },
            //            new Answer(){ Content = "B", Correct = false },
            //            new Answer(){ Content = "C", Correct = true },
            //            new Answer(){ Content = "D", Correct = false }
            //        }
            //    },
            //    q2 = new Question()
            //    {
            //        Content = "Wat is y?",
            //        CategoryId = 3,
            //        Answers = {
            //            new Answer(){ Content = "1", Correct = false },
            //            new Answer(){ Content = "2", Correct = true },
            //            new Answer(){ Content = "3", Correct = false },
            //            new Answer(){ Content = "4", Correct = false }
            //        }
            //    },
            //    q3 = new Question()
            //    {
            //        Content = "Hoe vind je z?",
            //        CategoryId = 4,
            //        Answers = {
            //            new Answer(){ Content = "1ste", Correct = true },
            //            new Answer(){ Content = "2de", Correct = false },
            //            new Answer(){ Content = "3de", Correct = false },
            //            new Answer(){ Content = "4de", Correct = false }
            //        }
            //    },
            //    q4 = new Question()
            //    {
            //        Content = "Wat is er fout aan k?",
            //        CategoryId = 1,
            //        Answers = {
            //            new Answer(){ Content = "alfa", Correct = false },
            //            new Answer(){ Content = "beta", Correct = false },
            //            new Answer(){ Content = "gamma", Correct = false },
            //            new Answer(){ Content = "delta", Correct = true }
            //        }
            //    },
            //    q5 = new Question()
            //    {
            //        Content = "Wat bedoelt men met c?",
            //        CategoryId = 5,
            //        Answers = {
            //            new Answer(){ Content = "I", Correct = false },
            //            new Answer(){ Content = "II", Correct = true },
            //            new Answer(){ Content = "III", Correct = false },
            //            new Answer(){ Content = "IV", Correct = false }
            //        }
            //    }
            //);

            //context.Quizzes.RemoveRange(context.Quizzes);

            //context.Quizzes.AddOrUpdate(
            //    new Quiz() { Name = "TestQuiz1", Questionnaire = { q1, q3 } },
            //    new Quiz() { Name = "TestQuiz2", Questionnaire = { q4, q5, q2 } }
            //);
        }
    }
}
