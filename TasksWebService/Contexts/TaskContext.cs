using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using TasksWebService.Models;

namespace TasksWebService.Contexts
{
    public class TaskContext : DbContext
    {
        public DbSet<Tasks> Tasks { get; set; }

        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
        }

    }
}
