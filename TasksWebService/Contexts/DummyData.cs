
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using TasksWebService.Models;

namespace TasksWebService.Contexts
{
    public class DummyData
    {
        public static void Initialize(Microsoft.AspNetCore.Builder.IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<TaskContext>();
                context.Database.EnsureCreated();
                //context.Database.Migrate();

                if (context.Tasks != null && context.Tasks.Any())
                    return;

                var tasks = GetTasks().ToArray();
                context.Tasks.AddRange(tasks);
                context.SaveChanges();
            }
        }

        public static List<Tasks> GetTasks()
        {
            List<Tasks> patients = new List<Tasks>() {
                new Tasks {
                    Title = "Schedule Daily Sales Report",
                    Description = "Report to list sales information at the end of the day",
                    Status = 400,
                    StartDate = new DateTime(2020, 5, 1),
                    EndDate = new DateTime(2020, 7, 20),
                    Priority = 5,
                    Category = "Green"
                }
            };
            return patients;
        }
    }
}
