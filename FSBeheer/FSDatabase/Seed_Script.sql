/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO dbo.Roles (Content) VALUES ('Salesmedewerker')
INSERT INTO dbo.Roles (Content) VALUES ('Operationele medewerker')
INSERT INTO dbo.Roles (Content) VALUES ('Inspecteur')

INSERT INTO dbo.QuestionTypes(Name) VALUES ('Open vraag')
INSERT INTO dbo.QuestionTypes(Name) VALUES ('Multiple Choice vraag')
INSERT INTO dbo.QuestionTypes(Name) VALUES ('Open tabelvraag')
INSERT INTO dbo.QuestionTypes(Name) VALUES ('Multiple Choice tabelvraag')

INSERT INTO dbo.Accounts (Username, Password, RoleId) VALUES ('bkoevoets@gmail.com', 'bartswachtwoord', 3)
INSERT INTO dbo.Accounts (Username, Password, RoleId) VALUES ('vnguyen@gmail.com', 'phiswachtwoord', 3)
INSERT INTO dbo.Accounts (Username, Password, RoleId) VALUES ('clancaster@gmail.com', 'cjswachtwoord', 3)
INSERT INTO dbo.Accounts (Username, Password, RoleId) VALUES ('earends@gmail.com', 'evertswachtwoord', 3)

INSERT INTO dbo.Inspectors (Name, Address, City, Zipcode, Email, PhoneNumber, CertificationDate, InvalidDate, BankNumber, AccountId)
VALUES ('Bart Koevoets', 'Bartsadres', 'Bartsstad', '1234BK', 'bkoevoets@gmail.com', '0612345678', '2018-1-1 00:00:00', '2019-1-1 00:00:00', 'NL01INGB0123456789', 1)
INSERT INTO dbo.Inspectors (Name, Address, City, Zipcode, Email, PhoneNumber, CertificationDate, InvalidDate, BankNumber, AccountId)
VALUES ('Phi Nguyen', 'Phisadres', 'Phisstad', '1234PN', 'pnguyen@gmail.com', '0612345678', '2018-1-1 00:00:00', '2019-1-1 00:00:00', 'NL01INGB0123456789', 2)
INSERT INTO dbo.Inspectors (Name, Address, City, Zipcode, Email, PhoneNumber, CertificationDate, InvalidDate, BankNumber, AccountId)
VALUES ('Curwen Lancaster', 'Curwensadres', 'Curwensstad', '1234CL', 'clancaster@gmail.com', '0612345678', '2018-1-1 00:00:00', '2019-1-1 00:00:00', 'NL01INGB0123456789', 3)
INSERT INTO dbo.Inspectors (Name, Address, City, Zipcode, Email, PhoneNumber, CertificationDate, InvalidDate, BankNumber, AccountId)
VALUES ('Evert Arends', 'Evertsadres', 'Evertsstad', '1234EA', 'earends@gmail.com', '0612345678', '2018-1-1 00:00:00', '2019-1-1 00:00:00', 'NL01INGB0123456789', 4)

INSERT INTO dbo.Inspections (State, Notes) VALUES ('Afgerond', 'Minstens 4 inspecteurs')

INSERT INTO dbo.Questionnaires (Name, Instructions, Version, Comments, InspectionId) VALUES ('VragenlijstEersteInspectie', 'Laat geen vragen leeg', 1, 'Dit is onze eerste inspectie, extra goed opletten!', 1)

INSERT INTO dbo.Questions (Content, Options, QuestionnaireId, QuestionTypeId) VALUES ('Hoeveel man is er op het festival?', '100; 200; 500; 1000', 1, 2)
INSERT INTO dbo.Questions (Content, Options, QuestionnaireId, QuestionTypeId) VALUES ('Hoe groot is het percentage van roest op het podium?', '10%; 20%; 50%; 100%', 1, 2)
INSERT INTO dbo.Questions (Content, Options, QuestionnaireId, QuestionTypeId) VALUES ('Wat is de draaglast van de fundament van het podium?', '100kg; 200kg; 500kg; 1000kg', 1, 2)
INSERT INTO dbo.Questions (Content, Options, QuestionnaireId, QuestionTypeId) VALUES ('Hoeveel bars zijn er op het festival?', '5; 10; 20; 40', 1, 2)

INSERT INTO dbo.Answers(Content, QuestionId, InspectorId) VALUES ('200', 1, 1)
INSERT INTO dbo.Answers(Content, QuestionId, InspectorId) VALUES ('100', 1, 2)
INSERT INTO dbo.Answers(Content, QuestionId, InspectorId) VALUES ('200', 1, 3)
INSERT INTO dbo.Answers(Content, QuestionId, InspectorId) VALUES ('500', 1, 4)
INSERT INTO dbo.Answers(Content, QuestionId, InspectorId) VALUES ('10%', 2, 1)
INSERT INTO dbo.Answers(Content, QuestionId, InspectorId) VALUES ('10%', 2, 2)
INSERT INTO dbo.Answers(Content, QuestionId, InspectorId) VALUES ('10%', 2, 3)
INSERT INTO dbo.Answers(Content, QuestionId, InspectorId) VALUES ('20%', 2, 4)
INSERT INTO dbo.Answers(Content, QuestionId, InspectorId) VALUES ('200kg', 3, 1)
INSERT INTO dbo.Answers(Content, QuestionId, InspectorId) VALUES ('200kg', 3, 2)
INSERT INTO dbo.Answers(Content, QuestionId, InspectorId) VALUES ('200kg', 3, 3)
INSERT INTO dbo.Answers(Content, QuestionId, InspectorId) VALUES ('200kg', 3, 4)
INSERT INTO dbo.Answers(Content, QuestionId, InspectorId) VALUES ('20', 4, 1)
INSERT INTO dbo.Answers(Content, QuestionId, InspectorId) VALUES ('10', 4, 2)
INSERT INTO dbo.Answers(Content, QuestionId, InspectorId) VALUES ('40', 4, 3)
INSERT INTO dbo.Answers(Content, QuestionId, InspectorId) VALUES ('20', 4, 4)