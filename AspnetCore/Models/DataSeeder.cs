﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetCore.Data;
namespace AspnetCore.Models
{
    public  static class DataSeeder
    {
        // TODO: Move this code when seed data is implemented in EF 7

        /// <summary>
        /// This is a workaround for missing seed data functionality in EF 7.0-rc1
        /// More info: https://github.com/aspnet/EntityFramework/issues/629
        /// </summary>
        /// <param name="app">
        /// An instance that provides the mechanisms to get instance of the database context.
        /// </param>
        public static void SeedData(this Microsoft.AspNetCore.Builder.IApplicationBuilder app)
        {
            var db = app.ApplicationServices.GetService(typeof(ApplicationDbContext));

            // TODO: Add seed logic here

            //db.SaveChanges();
        }
    }
}
