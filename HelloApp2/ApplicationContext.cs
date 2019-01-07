using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloApp2
{
    //Взаимодействие с базой данных в Entity Framework Core происходит посредством специального класса - контекста данных. 
    public class ApplicationContext:DbContext
    {
        public DbSet<User> Users { get; set; } // собственно сама таблица

        public ApplicationContext()
        {
            Database.EnsureCreated(); //если бд нет она создается если она есть то ничего непроисходит
        }

        //Кроме того, для настройки подключения нам надо переопределить метод OnConfiguring.
        //Передаваемый в него параметр класса DbContextOptionsBuilder 
        //с помощью метода UseSqlServer позволяет настроить строку подключения для соединения с MS SQL Server
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //строка подключения к локальной бд
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }
    }
}
//DbContext: определяет контекст данных, используемый для взаимодействия с базой данных
//
//DbSet/DbSet<TEntity>: представляет набор объектов, которые хранятся в базе данных
//
//DbContextOptionsBuilder: устанавливает параметры подключения