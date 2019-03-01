using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;

using MyFirstEFCoreProject.Data;
using MyFirstEFCoreProject.Model;

namespace MyFirstEFCoreProject
{
    public static class Commands
    {
        public static void ListAll() {
            using (var db = new AppDbContext()) {
                foreach (var todo in db.Todos.AsNoTracking().Include(a => a.Contact)) {
                    Console.WriteLine($"{todo.Text} by {todo.Contact.FirstName} {todo.Contact.LastName}");
                    Console.WriteLine($"     Completed({todo.Completed})");
                }
            }
        }

        public static void ListAllWithLogs() {
            var logs = new List<string>();
            using (var db = new AppDbContext())
            {
                var serviceProvider = db.GetInfrastructure();
                var loggerFactory = (ILoggerFactory)serviceProvider.GetService(typeof(ILoggerFactory));
                loggerFactory.AddProvider(new MyLoggerProvider(logs));

                foreach (var todo in db.Todos.AsNoTracking().Include(a => a.Contact))
                {
                    var webUrl = todo.Contact.LastName == null
                        ? "- no LastName given -"
                        : todo.Contact.LastName;
                    Console.WriteLine($"{todo.Text} by {todo.Contact.FirstName} {todo.Contact.LastName}");
                    Console.WriteLine($"     Completed({todo.Completed}");
                }
            }
            Console.WriteLine("---------- LOGS ------------------");
            foreach (var log in logs)
            {
                Console.WriteLine(log);
            }
        }

        public static void ChangeLastName() {
            Console.Write("Student LastName > ");
            var newLastName = Console.ReadLine();

            using (var db = new AppDbContext())
            {
                var todo = db.Todos
                    .Include(a => a.Contact)
                    .Single(b => b.Text == "Make handin");

                todo.Contact.LastName = newLastName;
                db.SaveChanges();
                Console.WriteLine("... SavedChanges called.");
            }

            ListAll();
        }

        public static void ChangeLastNameLogs() {
            var logs = new List<string>();
            Console.Write("Student LastName > ");
            var newLastName = Console.ReadLine();

            using (var db = new AppDbContext())
            {
                var serviceProvider = db.GetInfrastructure();
                var loggerFactory = (ILoggerFactory)serviceProvider.GetService(typeof(ILoggerFactory));
                loggerFactory.AddProvider(new MyLoggerProvider(logs));

                var book = db.Todos
                    .Include(a => a.Contact)
                    .Single(b => b.Text == "Make handin");
                book.Contact.LastName = newLastName;
                db.SaveChanges();
                Console.Write("... SavedChanges called.");
            }
            Console.WriteLine("---------- LOGS ------------------");
            foreach (var log in logs)
            {
                Console.WriteLine(log);
            }
        }

        public static bool WipeCreateSeed(bool onlyIfNoDatabase) {
            using (var db = new AppDbContext())
            {
                if (onlyIfNoDatabase && (db.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists())
                    return false;

                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                if (!db.Todos.Any())
                {
                    WriteTestData(db);
                    Console.WriteLine("Seeded database");
                }
            }
            return true;
        }

        private static void WriteTestData(this AppDbContext db)
        {
            var henrikKirk = new Contact
            {
                FirstName = "Henrik",
                LastName = "Kirk",
                Email = "henrik@ase.au.dk"
            };

            var todos = new List<Todo>
            {
                new Todo
                {
                    Text = "Uploade code example",
                    Completed = false,
                    Contact = henrikKirk
                },
                new Todo
                {
                    Text = "Prepare live demo",
                    Completed = true,
                    Contact = henrikKirk
                },
                new Todo
                {
                    Text = "Make handin",
                    Completed = true,
                    Contact = new Contact { FirstName = "Emil", LastName = "NotKnown"}
                },
                new Todo
                {
                    Text = "Make time schedule for Orbies",
                    Completed = true,
                    Contact = new Contact { FirstName = "Litte", LastName = "Dalsgaard", Email = "ld@ase.au.dk" }
                },
            };

            db.Todos.AddRange(todos);
            db.SaveChanges();
        }
    }
}