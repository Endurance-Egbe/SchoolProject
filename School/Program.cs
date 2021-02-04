using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using ORMs;
using ORMs.EFCoreRepository;
using ORMs.NHibernateRepository;
using School.Common;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sqlserver = new SQLiteNHibernate();
            var sqlserver = new SQLiteEFCore();
            var repo = new EFCoreRepository<SchoolModel>(sqlserver);
            //var repo = new NHibernateRepository<SchoolModel>(sqlserver);
            CreateModel(repo);
            Console.WriteLine("DataBaseLoaded");
            Console.ReadLine();
        }
        public static void CreateModel(IRepository<SchoolModel> repository)
        {
            //SCHOOL
            SchoolModel queenLandC = new SchoolModel()
            {
                Location = "Uzuoba",
                Name = "Queen land college",
            };
            SchoolModel brainField = new SchoolModel()
            {
                Location = "Uzuoba",
                Name = "Brain Field college",
            };

            // Principal

            Principal BrainFieldPrincipal = new Principal()
            {
                FirstName = "Mr Agbada",
                LastName = "Ekong",
                Gender = "Male",
                Location = "Uzuoba",

            };
            Principal QLCPrincipal = new Principal()
            {
                FirstName = "Mr Roseline",
                LastName = "Elekpa",
                Gender = "Female",
                Location = "Uzuoba",

            };

            
            //Teachers

            Teacher bFieldteacher1 = new Teacher { FirstName = "Grace", LastName = "Queen", Gender = "Female", Location = "Romuokoro",School= brainField };
            Teacher bFieldteacher2 = new Teacher { FirstName = "Magret", LastName = "Greg", Gender = "Female", Location = "Choba", School = brainField };
            Teacher bFieldteacher3 = new Teacher { FirstName = "Sarah", LastName = "John", Gender = "Female", Location = "Uzuoba", School = brainField };
            Teacher bFieldteacher4 = new Teacher { FirstName = "George", LastName = "Ukpai", Gender = "Male", Location = "Choba", School = brainField };
            Teacher bFieldteacher5 = new Teacher { FirstName = "Peter", LastName = "Keneth", Gender = "Male", Location = "Uzuoba", School = brainField };
            Teacher bFieldteacher6 = new Teacher { FirstName = "Cosmus", LastName = "Ben", Gender = "Male", Location = "Choba", School = brainField };
            Teacher bFieldteacher7 = new Teacher { FirstName = "Fred", LastName = "Ukpai", Gender = "Male", Location = "Romuola", School = brainField };
            var brainFieldTeachers = new List<Teacher> { bFieldteacher1, bFieldteacher2, bFieldteacher3, bFieldteacher4, bFieldteacher5, bFieldteacher6, bFieldteacher7 };

            Teacher queenLandTeacher1 = new Teacher { FirstName = "Sophia", LastName = "Queeneth", Gender = "Female", Location = "Romuokoro",School= queenLandC };
            Teacher queenLandTeacher2 = new Teacher { FirstName = "Magret", LastName = "Harry", Gender = "Female", Location = "Choba", School = queenLandC };
            Teacher queenLandTeacher3 = new Teacher { FirstName = "Danny", LastName = "Okoi", Gender = "Female", Location = "Uzuoba", School = queenLandC };
            Teacher queenLandTeacher4 = new Teacher { FirstName = "Bruno", LastName = "Ukpai", Gender = "Male", Location = "Choba", School = queenLandC };
            Teacher queenLandTeacher5 = new Teacher { FirstName = "Peter", LastName = "Nano", Gender = "Male", Location = "Uzuoba", School = queenLandC };
            Teacher queenLandTeacher6 = new Teacher { FirstName = "Victor", LastName = "Anni", Gender = "Male", Location = "Choba", School = queenLandC };
            Teacher queenLandTeacher7 = new Teacher { FirstName = "Fred", LastName = "Mandi", Gender = "Male", Location = "Romuola", School = queenLandC };
            var queeenLandTeachers = new List<Teacher> { queenLandTeacher1, queenLandTeacher2, queenLandTeacher3, queenLandTeacher4, queenLandTeacher5, queenLandTeacher6, queenLandTeacher7 };


            //CLASSES
            SchoolClass ss1BrainField = new SchoolClass()
            { Name = "SS1",School=brainField,Teacher=bFieldteacher1 };
            SchoolClass ss2BrainField = new SchoolClass()
            { Name = "SS2", School = brainField, Teacher = bFieldteacher2 };
            SchoolClass ss3BrainField = new SchoolClass()
            { Name = "SS3", School = brainField, Teacher = bFieldteacher3 };
            var bFieldClasses = new List<SchoolClass> { ss1BrainField, ss2BrainField, ss3BrainField };

            SchoolClass ss1QL = new SchoolClass()
            { Name = "SS1",School=queenLandC,Teacher=queenLandTeacher1 };
            SchoolClass ss2QL = new SchoolClass()
            { Name = "SS2", School = queenLandC, Teacher = queenLandTeacher2 };
            SchoolClass ss3QL = new SchoolClass()
            { Name = "SS3", School = queenLandC, Teacher = queenLandTeacher3 };
            var queenLandClasses = new List<SchoolClass> { ss1QL, ss2QL, ss3QL };

            //subjects for queen land 
            Subject english1 = new Subject() { Name = "English1",SchoolClass=ss1QL,Teacher=queenLandTeacher1 };
            Subject english2 = new Subject() { Name = "English2", SchoolClass = ss2QL, Teacher = queenLandTeacher2 };
            Subject english3 = new Subject() { Name = "English3", SchoolClass = ss3QL, Teacher = queenLandTeacher1 };
            Subject mathematics1 = new Subject() { Name = "Mathematics1",SchoolClass = ss1QL, Teacher = queenLandTeacher4 };
            Subject mathematics2 = new Subject() { Name = "Mathematics2" ,SchoolClass = ss2QL, Teacher = queenLandTeacher3 };
            Subject mathematics3 = new Subject() { Name = "Mathematics3", SchoolClass = ss3QL, Teacher = queenLandTeacher6 };
            Subject physics1 = new Subject() { Name = "Physics1", SchoolClass = ss1QL, Teacher = queenLandTeacher7 };
            Subject physics2 = new Subject() { Name = "Physics2", SchoolClass = ss2QL, Teacher = queenLandTeacher3 };
            Subject physics3 = new Subject() { Name = "Physics3", SchoolClass = ss3QL, Teacher = queenLandTeacher3 };
            Subject chemistry1 = new Subject() { Name = "Chemistry1", SchoolClass = ss1QL, Teacher = queenLandTeacher5 };
            Subject chemistry2 = new Subject() { Name = "Chemistry2", SchoolClass = ss2QL, Teacher = queenLandTeacher5 };
            Subject chemistry3 = new Subject() { Name = "Chemistry3", SchoolClass = ss3QL, Teacher = queenLandTeacher7 };
            Subject biology1 = new Subject() { Name = "Biology1", SchoolClass = ss1QL, Teacher = queenLandTeacher2 };
            Subject biology2 = new Subject() { Name = "Biology2", SchoolClass = ss2QL, Teacher = queenLandTeacher2 };
            Subject biology3 = new Subject() { Name = "Biology3", SchoolClass = ss3QL, Teacher = queenLandTeacher5 };
            Subject geography1 = new Subject() { Name = "Geography1", SchoolClass = ss1QL, Teacher = queenLandTeacher6 };
            Subject geography2 = new Subject() { Name = "Geography2", SchoolClass = ss2QL, Teacher = queenLandTeacher6 };
            Subject geography3 = new Subject() { Name = "Geography3", SchoolClass = ss3QL, Teacher = queenLandTeacher6 };

            //School subjet Table 
            //...........SUBJECTS
            var ss1Subject = new List<Subject> { english1, mathematics1, chemistry1, physics1, biology1, geography1 };
            var ss2Subject = new List<Subject> { english2, mathematics2, chemistry2, physics2, biology2, geography2 };
            var ss3Subject = new List<Subject> { english3, mathematics3, chemistry3, physics3, biology3, geography3 };

            //subjects for brainfield 
            Subject english1bfd = new Subject() { Name = "English1", SchoolClass = ss1BrainField, Teacher = bFieldteacher1 };
            Subject english2bfd = new Subject() { Name = "English2", SchoolClass = ss2BrainField, Teacher = bFieldteacher2 };
            Subject english3bfd = new Subject() { Name = "English3", SchoolClass = ss3BrainField, Teacher = bFieldteacher1 };
            Subject mathematics1bfd = new Subject() { Name = "Mathematics1", SchoolClass = ss1BrainField, Teacher = bFieldteacher1 };
            Subject mathematics2bfd = new Subject() { Name = "Mathematics2", SchoolClass = ss2BrainField, Teacher = bFieldteacher3 };
            Subject mathematics3bfd = new Subject() { Name = "Mathematics3", SchoolClass = ss3BrainField, Teacher = bFieldteacher6 };
            Subject physics1bfd = new Subject() { Name = "Physics1", SchoolClass = ss1BrainField, Teacher = bFieldteacher1 };
            Subject physics2bfd = new Subject() { Name = "Physics2", SchoolClass = ss2BrainField, Teacher = bFieldteacher3 };
            Subject physics3bfd = new Subject() { Name = "Physics3", SchoolClass = ss3BrainField, Teacher = bFieldteacher3 };
            Subject chemistry1bfd = new Subject() { Name = "Chemistry1", SchoolClass = ss1BrainField, Teacher = bFieldteacher1 };
            Subject chemistry2bfd = new Subject() { Name = "Chemistry2", SchoolClass = ss2BrainField, Teacher = bFieldteacher5 };
            Subject chemistry3bfd = new Subject() { Name = "Chemistry3", SchoolClass = ss3BrainField, Teacher = bFieldteacher1 };
            Subject biology1bfd = new Subject() { Name = "Biology1", SchoolClass = ss1BrainField, Teacher = bFieldteacher2 };
            Subject biology2bfd = new Subject() { Name = "Biology2", SchoolClass = ss2BrainField, Teacher = bFieldteacher2 };
            Subject biology3bfd = new Subject() { Name = "Biology3", SchoolClass = ss3BrainField, Teacher = bFieldteacher5 };
            Subject geography1bfd = new Subject() { Name = "Geography1", SchoolClass = ss1BrainField, Teacher = bFieldteacher6 };
            Subject geography2bfd = new Subject() { Name = "Geography2", SchoolClass = ss2BrainField, Teacher = bFieldteacher6 };
            Subject geography3bfd = new Subject() { Name = "Geography3", SchoolClass = ss3BrainField, Teacher = bFieldteacher6 };

            //School subjet Table 
            //...........SUBJECTS
            var ss1Subjectbfd = new List<Subject> { english1bfd, mathematics1bfd, chemistry1bfd, physics1bfd, biology1bfd, geography1bfd };
            var ss2Subjectbfd = new List<Subject> { english2bfd, mathematics2bfd, chemistry2bfd, physics2bfd, biology2bfd, geography2bfd };
            var ss3Subjectbfd = new List<Subject> { english3bfd, mathematics3bfd, chemistry3bfd, physics3bfd, biology3bfd, geography3bfd };
            ////subjects 
            //Subject english1 = new Subject() { Name = "English1" };
            //Subject english2 = new Subject() { Name = "English2" };
            //Subject english3 = new Subject() { Name = "English3" };
            //Subject mathematics1 = new Subject() { Name = "Mathematics1" };
            //Subject mathematics2 = new Subject() { Name = "Mathematics2" };
            //Subject mathematics3 = new Subject() { Name = "Mathematics3" };
            //Subject physics1 = new Subject() { Name = "Physics1" };
            //Subject physics2 = new Subject() { Name = "Physics2" };
            //Subject physics3 = new Subject() { Name = "Physics3" };
            //Subject chemistry1 = new Subject() { Name = "Chemistry1" };
            //Subject chemistry2 = new Subject() { Name = "Chemistry2" };
            //Subject chemistry3 = new Subject() { Name = "Chemistry3" };
            //Subject biology1 = new Subject() { Name = "Biology1" };
            //Subject biology2 = new Subject() { Name = "Biology2" };
            //Subject biology3 = new Subject() { Name = "Biology3" };
            //Subject geography1 = new Subject() { Name = "Geography1" };
            //Subject geography2 = new Subject() { Name = "Geography2" };
            //Subject geography3 = new Subject() { Name = "Geography3" };

            // Subject table
            // .................queen land
            //english1.Teacher = queenLandTeacher1;
            //english1.SchoolClass = ss1QL;
            //english2.Teacher = queenLandTeacher2;
            //english2.SchoolClass = ss2QL;
            //english3.Teacher = queenLandTeacher2;
            //english3.SchoolClass = ss3QL;
            //mathematics1.Teacher = queenLandTeacher2;
            //mathematics1.SchoolClass = ss1QL;
            //mathematics2.Teacher = queenLandTeacher4;
            //mathematics2.SchoolClass = ss2QL;
            //mathematics3.Teacher = queenLandTeacher5;
            //mathematics3.SchoolClass = ss3QL;
            //biology1.Teacher = queenLandTeacher6;
            //biology1.SchoolClass = ss1QL;
            //biology2.Teacher = queenLandTeacher4;
            //biology2.SchoolClass = ss2QL;
            //biology3.Teacher = queenLandTeacher1;
            //biology3.SchoolClass = ss3QL;
            //physics1.Teacher = queenLandTeacher7;
            //physics1.SchoolClass = ss1QL;
            //physics2.Teacher = queenLandTeacher7;
            //physics2.SchoolClass = ss2QL;
            //physics3.Teacher = queenLandTeacher5;
            //physics3.SchoolClass = ss3QL;
            //chemistry1.Teacher = queenLandTeacher6;
            //chemistry1.SchoolClass = ss1QL;
            //chemistry2.Teacher = queenLandTeacher2;
            //chemistry2.SchoolClass = ss2QL;
            //chemistry3.Teacher = queenLandTeacher6;
            //chemistry3.SchoolClass = ss3QL;
            //geography1.Teacher = queenLandTeacher7;
            //geography1.SchoolClass = ss1QL;
            //geography2.Teacher = queenLandTeacher1;
            //geography2.SchoolClass = ss2QL;
            //geography3.Teacher = queenLandTeacher1;
            //geography3.SchoolClass = ss3QL;

            //// .................Brain Field
            //english1.Teacher = bFieldteacher1;
            //english1.SchoolClass = ss1BrainField;
            //english2.Teacher = bFieldteacher2;
            //english2.SchoolClass = ss1BrainField;
            //english3.Teacher = bFieldteacher2;
            //english3.SchoolClass = ss1BrainField;
            //mathematics1.Teacher = bFieldteacher2;
            //mathematics1.SchoolClass = ss1BrainField;
            //mathematics2.Teacher = bFieldteacher4;
            //mathematics2.SchoolClass = ss2BrainField;
            //mathematics3.Teacher = bFieldteacher5;
            //mathematics3.SchoolClass = ss3BrainField;
            //biology1.Teacher = bFieldteacher6;
            //biology1.SchoolClass = ss1BrainField;
            //biology2.Teacher = bFieldteacher4;
            //biology2.SchoolClass = ss2BrainField;
            //biology3.Teacher = bFieldteacher1;
            //biology3.SchoolClass = ss3BrainField;
            //physics1.Teacher = bFieldteacher7;
            //physics1.SchoolClass = ss1BrainField;
            //physics2.Teacher = bFieldteacher7;
            //physics2.SchoolClass = ss2BrainField;
            //physics3.Teacher = bFieldteacher5;
            //physics3.SchoolClass = ss3BrainField;
            //chemistry1.Teacher = bFieldteacher6;
            //chemistry1.SchoolClass = ss1BrainField;
            //chemistry2.Teacher = bFieldteacher2;
            //chemistry2.SchoolClass = ss2BrainField;
            //chemistry3.Teacher = bFieldteacher6;
            //chemistry3.SchoolClass = ss3BrainField;
            //geography1.Teacher = bFieldteacher7;
            //geography1.SchoolClass = ss1BrainField;
            //geography2.Teacher = bFieldteacher1;
            //geography2.SchoolClass = ss2BrainField;
            //geography3.Teacher = bFieldteacher1;
            //geography3.SchoolClass = ss3BrainField;

            
            //Studends at BrainField
            Student brainFieldStudent1 = new Student { FirstName = "Agness", LastName = "David", Gender = "Female", Location = "Romuola",School= brainField,SchoolClass=ss1BrainField,Subjects= ss1Subjectbfd };
            Student brainFieldStudent2 = new Student { FirstName = "Owen", LastName = "Greg", Gender = "Male", Location = "Romuokoro", School = brainField, SchoolClass = ss1BrainField, Subjects = ss1Subjectbfd };
            Student brainFieldStudent3 = new Student { FirstName = "Magret", LastName = "David", Gender = "Female", Location = "Romuokoro", School = brainField, SchoolClass = ss1BrainField, Subjects = ss1Subjectbfd };
            Student brainFieldStudent4 = new Student { FirstName = "Antonia", LastName = "Elmon", Gender = "Female", Location = "Romuola", School = brainField, SchoolClass = ss2BrainField, Subjects = ss2Subjectbfd };
            Student brainFieldStudent5 = new Student { FirstName = "Victor", LastName = "Abang", Gender = "Male", Location = "Uzuoba", School = brainField, SchoolClass = ss2BrainField, Subjects = ss2Subjectbfd };
            Student brainFieldStudent6 = new Student { FirstName = "Great", LastName = "Obong", Gender = "Male", Location = "Romuola", School = brainField, SchoolClass = ss2BrainField, Subjects = ss2Subjectbfd };
            Student brainFieldStudent7 = new Student { FirstName = "Victory", LastName = "David", Gender = "Female", Location = "Uzuoba", School = brainField, SchoolClass = ss2BrainField, Subjects = ss2Subjectbfd };
            Student brainFieldStudent8 = new Student { FirstName = "David", LastName = "Great", Gender = "Female", Location = "Uzuoba", School = brainField, SchoolClass = ss3BrainField, Subjects = ss3Subjectbfd };
            Student brainFieldStudent9 = new Student { FirstName = "Victory", LastName = "Elmon", Gender = "Female", Location = "Uzuoba", School = brainField, SchoolClass = ss3BrainField, Subjects = ss3Subjectbfd };
            Student brainFieldStudent10 = new Student { FirstName = "Antonia", LastName = "David", Gender = "Female", Location = "Uzuoba", School = brainField, SchoolClass = ss3BrainField, Subjects = ss3Subjectbfd };
            Student brainFieldStudent11 = new Student { FirstName = "Elmon", LastName = "David", Gender = "Female", Location = "Uzuoba", School = brainField, SchoolClass = ss3BrainField, Subjects = ss3Subjectbfd };
            
            var brainFieldStudents = new List<Student> { brainFieldStudent1, brainFieldStudent2, brainFieldStudent3, brainFieldStudent4, brainFieldStudent5, brainFieldStudent6, brainFieldStudent7, brainFieldStudent8, brainFieldStudent9, brainFieldStudent10, brainFieldStudent11 };

            //Studends at Queen Land College

            Student queenLandCStudents1 = new Student { FirstName = "Raymond", LastName = "David", Gender = "Male", Location = "Romuola",School= queenLandC,SchoolClass=ss1QL,Subjects= ss1Subject };
            Student queenLandCStudents2 = new Student { FirstName = "Owen", LastName = "Samuel", Gender = "Male", Location = "Romuokoro", School = queenLandC, SchoolClass = ss1QL, Subjects = ss1Subject};
            Student queenLandCStudents3 = new Student { FirstName = "Lovelina", LastName = "Ken", Gender = "Female", Location = "Romuokoro", School = queenLandC, SchoolClass = ss1QL, Subjects = ss1Subject };
            Student queenLandCStudents4 = new Student { FirstName = "Debbie", LastName = "Manuel", Gender = "Female", Location = "Romuola", School = queenLandC, SchoolClass = ss2QL, Subjects = ss2Subject };
            Student queenLandCStudents5 = new Student { FirstName = "Victor", LastName = "Solomon", Gender = "Male", Location = "Uzuoba", School = queenLandC, SchoolClass = ss2QL, Subjects = ss2Subject };
            Student queenLandCStudents6 = new Student { FirstName = "Great", LastName = "Ina", Gender = "Male", Location = "Romuola", School = queenLandC, SchoolClass = ss2QL, Subjects = ss2Subject };
            Student queenLandCStudents7 = new Student { FirstName = "Grace", LastName = "Rex", Gender = "Female", Location = "Uzuoba", School = queenLandC, SchoolClass = ss2QL, Subjects = ss2Subject };
            Student queenLandCStudents8 = new Student { FirstName = "Magret", LastName = "Obong", Gender = "Female", Location = "Romuola", School = queenLandC, SchoolClass = ss3QL, Subjects = ss3Subject};
            Student queenLandCStudents9 = new Student { FirstName = "Abang", LastName = "Manuel", Gender = "Male", Location = "Romuola", School = queenLandC, SchoolClass = ss3QL, Subjects = ss3Subject };
            Student queenLandCStudents10 = new Student { FirstName = "Debbie", LastName = "Great", Gender = "Female", Location = "Romuola", School = queenLandC, SchoolClass = ss3QL, Subjects = ss3Subject };
            Student queenLandCStudents11 = new Student { FirstName = "Great", LastName = "Obong", Gender = "Male", Location = "Romuola", School = queenLandC, SchoolClass = ss3QL, Subjects = ss3Subject };
            var queenLandStudents = new List<Student> { queenLandCStudents1, queenLandCStudents2, queenLandCStudents3, queenLandCStudents4, queenLandCStudents5, queenLandCStudents6, queenLandCStudents7, queenLandCStudents8, queenLandCStudents9, queenLandCStudents10, queenLandCStudents11 };

            //student brain field
            ss1BrainField.Students = new List<Student> { brainFieldStudent1, brainFieldStudent2, brainFieldStudent3 };
            ss2BrainField.Students = new List<Student> { brainFieldStudent4, brainFieldStudent5, brainFieldStudent6,brainFieldStudent7 };
            ss3BrainField.Students = new List<Student> { brainFieldStudent8, brainFieldStudent9, brainFieldStudent10,brainFieldStudent11 };
            // queen land
            ss1QL.Students = new List<Student> { queenLandCStudents1, queenLandCStudents2, queenLandCStudents3 };
            ss2QL.Students = new List<Student> { queenLandCStudents4, queenLandCStudents5, queenLandCStudents6,queenLandCStudents7 };
            ss3QL.Students = new List<Student> { queenLandCStudents8, queenLandCStudents9, queenLandCStudents10,queenLandCStudents11 };

            //classes
            brainField.Principal = BrainFieldPrincipal;
            brainField.SchoolClasses = bFieldClasses;
            brainField.Students = brainFieldStudents;
            brainField.Teachers = brainFieldTeachers;

            queenLandC.Principal = QLCPrincipal;
            queenLandC.SchoolClasses = queenLandClasses;
            queenLandC.Students = queenLandStudents;
            queenLandC.Teachers = queeenLandTeachers;

            repository.CreateModel(brainField);
            repository.CreateModel(queenLandC);


            
            ////...............load stuent and subject



            //ss1QL.Students = ss1StudentsQL;
            //ss1QL.Subjects = ss1Subject;
            //ss1BrainField.Students = ss1StudentsBField;
            //ss1BrainField.Subjects = ss1Subject;
            //ss2QL.Students = ss2StudentsQL;
            //ss2QL.Subjects = ss2Subject;
            //ss2BrainField.Students = ss2StudentsBField;
            //ss2BrainField.Subjects = ss2Subject;
            //ss3QL.Students = ss3StudentsQL;
            //ss3QL.Subjects = ss3Subject;
            //ss3BrainField.Students = ss3StudentsBField;
            //ss3BrainField.Subjects = ss3Subject;



            
            //......ss1
            //english1.SchoolClass = ss1QL;
            //mathematics1.SchoolClass = ss1QL;
            //biology1.SchoolClass = ss1QL;
            //physics1.SchoolClass = ss1QL;
            //chemistry1.SchoolClass = ss1QL;
            //geography1.SchoolClass = ss1QL;

            ////...........ss2
            //english2.SchoolClass = ss2QL;
            //mathematics2.SchoolClass = ss2QL;
            //biology2.SchoolClass = ss2QL;
            //physics2.SchoolClass = ss2QL;
            //chemistry2.SchoolClass = ss2QL;
            //geography2.SchoolClass = ss2QL;

            ////............SS3
            //english3.SchoolClass = ss3QL;
            //mathematics3.SchoolClass = ss3QL;
            //biology3.SchoolClass = ss3QL;
            //physics3.SchoolClass = ss3QL;
            //chemistry3.SchoolClass = ss3QL;
            //geography3.SchoolClass = ss3QL;


            // .................Brain Field
            //english1.Teacher = new List<Teacher> { bFieldteacher1 };
            //english2.Teacher = new List<Teacher> { bFieldteacher2 };
            //english3.Teacher = new List<Teacher> { bFieldteacher2 };
            //mathematics1.Teacher = new List<Teacher> { bFieldteacher2 };
            //mathematics2.Teacher = new List<Teacher> { bFieldteacher4 };
            //mathematics3.Teacher = new List<Teacher> { bFieldteacher5 };
            //biology1.Teacher = new List<Teacher> { bFieldteacher6 };
            //biology2.Teacher = new List<Teacher> { bFieldteacher4 };
            //biology3.Teacher = new List<Teacher> { bFieldteacher1 };
            //physics1.Teacher = new List<Teacher> { bFieldteacher7 };
            //physics2.Teacher = new List<Teacher> { bFieldteacher7 };
            //physics3.Teacher = new List<Teacher> { bFieldteacher5 };
            //chemistry1.Teacher = new List<Teacher> { bFieldteacher6 };
            //chemistry2.Teacher = new List<Teacher> { bFieldteacher2 };
            //chemistry3.Teacher = new List<Teacher> { bFieldteacher6 };
            //geography1.Teacher = new List<Teacher> { bFieldteacher7 };
            //geography2.Teacher = new List<Teacher> { bFieldteacher1 };
            //geography3.Teacher = new List<Teacher> { bFieldteacher1 };

            //......ss1
            //english1.SchoolClass = ss1BrainField;
            //mathematics1.SchoolClass = ss1BrainField;
            //biology1.SchoolClass = ss1BrainField;
            //physics1.SchoolClass = ss1BrainField;
            //chemistry1.SchoolClass = ss1BrainField;
            //geography1.SchoolClass = ss1BrainField;

            ////...........ss2
            //english2.SchoolClass = ss2BrainField;
            //mathematics2.SchoolClass = ss2BrainField;
            //biology2.SchoolClass = ss2BrainField;
            //physics2.SchoolClass = ss2BrainField;
            //chemistry2.SchoolClass = ss2BrainField;
            //geography2.SchoolClass = ss2BrainField;

            ////............SS3
            //english3.SchoolClass = ss3BrainField;
            //mathematics3.SchoolClass = ss3BrainField;
            //biology3.SchoolClass = ss3BrainField;
            //physics3.SchoolClass = ss3BrainField;
            //chemistry3.SchoolClass = ss3BrainField;
            //geography3.SchoolClass = ss3BrainField;

            //Schools
            //SchoolModel queenLandC = new SchoolModel()
            //{
            //    Location = "Uzuoba",
            //    Name = "Queen land college",
            //    Principal = QLCPrincipal,
            //    SchoolClasses = new List<SchoolClass> { ss1QL, ss2QL, ss3QL },

            //};
            //SchoolModel brainField = new SchoolModel()
            //{
            //    Location = "Uzuoba",
            //    Name = "Brain Field college",
            //    Principal = BrainFieldPrincipal,
            //    SchoolClasses = new List<SchoolClass> { ss1BrainField, ss2BrainField, ss3BrainField }
            //};
            //// class
            //ss1QL.School = queenLandC;
            //ss2QL.School = queenLandC;
            //ss3QL.School = queenLandC;
            //ss1BrainField.School = brainField;
            //ss2BrainField.School = brainField;
            //ss3BrainField.School = brainField;

            //// STUDENT table
            //// brain field
            //brainFieldStudent1.School = brainField;
            //brainFieldStudent1.SchoolClass = ss1BrainField;
            //brainFieldStudent2.School = brainField;
            //brainFieldStudent2.SchoolClass = ss1BrainField;
            //brainFieldStudent3.School = brainField;
            //brainFieldStudent3.SchoolClass = ss1BrainField;
            //brainFieldStudent4.School = brainField;
            //brainFieldStudent4.SchoolClass = ss2BrainField;
            //brainFieldStudent5.School = brainField;
            //brainFieldStudent5.SchoolClass = ss2BrainField;
            //brainFieldStudent6.School = brainField;
            //brainFieldStudent6.SchoolClass = ss2BrainField;
            //brainFieldStudent7.School = brainField;
            //brainFieldStudent7.SchoolClass = ss3BrainField;
            //brainFieldStudent8.School = brainField;
            //brainFieldStudent8.SchoolClass = ss3BrainField;
            //brainFieldStudent9.School = brainField;
            //brainFieldStudent9.SchoolClass = ss3BrainField;
            //brainFieldStudent10.School = brainField;
            //brainFieldStudent10.SchoolClass = ss3BrainField;
            //brainFieldStudent11.School = brainField;
            //brainFieldStudent11.SchoolClass = ss3BrainField;
            //// Queen land College
            //queenLandCStudents1.School = queenLandC;
            //queenLandCStudents1.SchoolClass = ss1QL;
            //queenLandCStudents2.School = queenLandC;
            //queenLandCStudents2.SchoolClass = ss1QL;
            //queenLandCStudents3.School = queenLandC;
            //queenLandCStudents3.SchoolClass = ss1QL;
            //queenLandCStudents4.School = queenLandC;
            //queenLandCStudents4.SchoolClass = ss2QL;
            //queenLandCStudents5.School = queenLandC;
            //queenLandCStudents5.SchoolClass = ss2QL;
            //queenLandCStudents6.School = queenLandC;
            //queenLandCStudents6.SchoolClass = ss2QL;
            //queenLandCStudents7.School = queenLandC;
            //queenLandCStudents7.SchoolClass = ss3QL;
            //queenLandCStudents8.School = queenLandC;
            //queenLandCStudents8.SchoolClass = ss3QL;
            //queenLandCStudents9.School = queenLandC;
            //queenLandCStudents9.SchoolClass = ss3QL;
            //queenLandCStudents10.School = queenLandC;
            //queenLandCStudents10.SchoolClass = ss3QL;
            //queenLandCStudents11.School = queenLandC;
            //queenLandCStudents11.SchoolClass = ss3QL;

            ////teacher table
            //bFieldteacher1.School = brainField;
            //bFieldteacher2.School = brainField;
            //bFieldteacher3.School = brainField;
            //bFieldteacher4.School = brainField;
            //bFieldteacher5.School = brainField;
            //bFieldteacher6.School = brainField;
            //bFieldteacher7.School = brainField;

            //queenLandTeacher1.School = queenLandC;
            //queenLandTeacher2.School = queenLandC;
            //queenLandTeacher3.School = queenLandC;
            //queenLandTeacher4.School = queenLandC;
            //queenLandTeacher5.School = queenLandC;
            //queenLandTeacher6.School = queenLandC;
            //queenLandTeacher7.School = queenLandC;



            //school1.SchoolClasses.Add(new SchoolClass() { Name = "SS1" });
            //school1.Students.Add(new Student() { FirstName = "Glory", LastName = "Akan", Gender = "Female", Location = "Barracks" });

            //Studends at BrainField
            //List<Student> brainFieldStudents = new List<Student>();
            //brainFieldStudents.Add(new Student{ FirstName = "Agness", LastName = "David", Gender = "Female", Location = "Romuola", School = brainField });
            //brainFieldStudents.Add(new Student{ FirstName = "Owen", LastName = "Greg", Gender = "Male", Location = "Romuokoro", School = brainField });
            //brainFieldStudents.Add(new Student{ FirstName = "Magret", LastName = "David", Gender = "Female", Location = "Romuokoro", School = brainField });
            //brainFieldStudents.Add(new Student{ FirstName = "Antonia", LastName = "Elmon", Gender = "Female", Location = "Romuola", School = brainField });
            //brainFieldStudents.Add(new Student{ FirstName = "Victor", LastName = "Abang", Gender = "Male", Location = "Uzuoba", School = brainField });
            //brainFieldStudents.Add(new Student{ FirstName = "Great", LastName = "Obong", Gender = "Male", Location = "Romuola", School = brainField });
            //brainFieldStudents.Add(new Student{ FirstName = "Victory", LastName = "David", Gender = "Female", Location = "Uzuoba", School = brainField });

            //brainField.Students = brainFieldStudents;

            ////Studends at Queen Land College
            //List<Student> queenLandCStudents = new List<Student>();
            //queenLandCStudents.Add(new Student{ FirstName = "Raymond", LastName = "David", Gender = "Maleale", Location = "Romuola", School = queenLandC });
            //queenLandCStudents.Add(new Student{ FirstName = "Owen", LastName = "Samuel", Gender = "Male", Location = "Romuokoro", School = queenLandC });
            //queenLandCStudents.Add(new Student{ FirstName = "Lovelina", LastName = "Ken", Gender = "Female", Location = "Romuokoro", School = queenLandC });
            //queenLandCStudents.Add(new Student{ FirstName = "Debbie", LastName = "Manuel", Gender = "Female", Location = "Romuola", School = queenLandC });
            //queenLandCStudents.Add(new Student{ FirstName = "Victor", LastName = "Solomon", Gender = "Male", Location = "Uzuoba", School = queenLandC });
            //queenLandCStudents.Add(new Student{ FirstName = "Great", LastName = "Ina", Gender = "Male", Location = "Romuola", School = queenLandC });
            //queenLandCStudents.Add(new Student{ FirstName = "Grace", LastName = "Rex", Gender = "Female", Location = "Uzuoba", School = queenLandC });

            //queenLandC.Students = queenLandCStudents;

            ////subjects in ss1 class
            //SchoolClass ss1ClassQueenLand = new SchoolClass() { Name = "SS1",School= queenLandC };
            //SchoolClass ss1ClassBrainfield = new SchoolClass() { Name = "SS1", School = brainField };
            //List<Subject> ss1Subjects = new List<Subject>();
            //ss1Subjects.Add(new Subject { Name = "Chemistry", SchoolClass = ss1ClassQueenLand });
            //ss1Subjects.Add(new Subject { Name = "Mathematics", SchoolClass = ss1ClassQueenLand });
            //ss1Subjects.Add(new Subject { Name = "English", SchoolClass = ss1ClassQueenLand });
            //ss1Subjects.Add(new Subject { Name = "Biology", SchoolClass = ss1ClassQueenLand });
            //ss1Subjects.Add(new Subject { Name = "Agriculture", SchoolClass = ss1ClassQueenLand });
            //ss1ClassQueenLand.Subjects = ss1Subjects;
            //ss1ClassBrainfield.Subjects = ss1Subjects;


            ////TEACHERS AT BRAINFIELD
            //List<Teacher> brainFieldTeachers = new List<Teacher>();
            //brainFieldTeachers.Add(new Teacher { FirstName = "Grace", LastName = "Queen", Gender = "Female", Location = "Romuokoro", School = brainField,SchoolClasses=null});
            //brainFieldTeachers.Add(new Teacher { FirstName = "Magret", LastName = "Greg", Gender = "Female", Location = "Choba", School = brainField, SchoolClasses = null });
            //brainFieldTeachers.Add(new Teacher { FirstName = "Sarah", LastName = "John", Gender = "Female", Location = "Uzuoba", School = brainField, SchoolClasses = null });
            //brainFieldTeachers.Add(new Teacher { FirstName = "George", LastName = "Ukpai", Gender = "Male", Location = "Choba", School = brainField, SchoolClasses = null });
            //brainFieldTeachers.Add(new Teacher { FirstName = "Peter", LastName = "Keneth", Gender = "Male", Location = "Uzuoba", School = brainField, SchoolClasses = null });
            //brainFieldTeachers.Add(new Teacher { FirstName = "Cosmus", LastName = "Ben", Gender = "Male", Location = "Choba", School = brainField, SchoolClasses = null });
            //brainFieldTeachers.Add(new Teacher { FirstName = "Fred", LastName = "Ukpai", Gender = "Male", Location = "Romuola", School = brainField, SchoolClasses = null });
            //brainField.Teachers = brainFieldTeachers;

            ////TEACHERS at Queen Land College
            //List<Teacher> queenLandTeachers = new List<Teacher>();
            //queenLandTeachers.Add(new Teacher { FirstName = "Sophia", LastName = "Queeneth", Gender = "Female", Location = "Romuokoro", School = queenLandC, SchoolClasses = null });
            //queenLandTeachers.Add(new Teacher { FirstName = "Magret", LastName = "Harry", Gender = "Female", Location = "Choba", School = queenLandC, SchoolClasses = null });
            //queenLandTeachers.Add(new Teacher { FirstName = "Danny", LastName = "Okoi", Gender = "Female", Location = "Uzuoba", School = queenLandC, SchoolClasses = null });
            //queenLandTeachers.Add(new Teacher { FirstName = "Bruno", LastName = "Ukpai", Gender = "Male", Location = "Choba", School = queenLandC, SchoolClasses = null });
            //queenLandTeachers.Add(new Teacher { FirstName = "Peter", LastName = "Nano", Gender = "Male", Location = "Uzuoba", School = queenLandC, SchoolClasses = null });
            //queenLandTeachers.Add(new Teacher { FirstName = "Victor", LastName = "Anni", Gender = "Male", Location = "Choba", School = queenLandC, SchoolClasses = null });
            //queenLandTeachers.Add(new Teacher { FirstName = "Fred", LastName = "Mandi", Gender = "Male", Location = "Romuola", School = queenLandC, SchoolClasses = null });

            //queenLandC.Teachers = queenLandTeachers;





            //Principal principal1 = new Principal()
            //{
            //    FirstName = "Mr Ejerugba",
            //    LastName = "Peter",
            //    Gender = "Male",
            //    Location = "Uzuoba",

            //};
            //Teacher teacher = new Teacher()
            //{
            //    FirstName = "Maria",
            //    LastName = "Sandra",
            //    Gender = "female",
            //    Location = "Uzuoba",
            //    School = school1,

            //};
            //teacher.SchoolClasses.Add(new SchoolClass() { Name = "SS1", Teacher = null, School = school1 });
            //SchoolClass schoolClass = new SchoolClass()
            //{
            //    Name = "SS1",

            //    Subjects =,
            //    Teacher =teacher
            //};
            //schoolClass.Students.Add(
            //new Student()
            //{
            //    FirstName = "Matthew",
            //    LastName = "Lawrence",
            //    Gender = "Male",
            //    Location = "Nkpolu",
            //    School = school1,
            //    SchoolClass = schoolClass
            //}
            //);
            //schoolClass.Students.Add(
            //new Student()
            //{
            //    FirstName = "Christopher",
            //    LastName = "Akan",
            //    Gender = "Male",
            //    Location = "Nkpolu",
            //    School = school1,
            //    SchoolClass = schoolClass
            //}
            //);
            //schoolClass

            //SchoolModel school2 = new SchoolModel()
            //{
            //    Location = "Uzuoba",
            //    Name = "Glory land college",
            //    Principal=principal1
            //};
            //school2.SchoolClasses.Add(new SchoolClass() { Name = "SS2" });
            //school2.Students.Add(new Student() { FirstName = "Rosey", LastName = "Akan", Gender = "Female", Location = "Barracks" });
            //school1.Teachers.Add(new Teacher() { FirstName="Serah",LastName="Moses",Gender="Female",Location="Uzuoba",SchoolClasses=,Subjects=})
            //repository.CreateModel(school2);
        }
    }
}
