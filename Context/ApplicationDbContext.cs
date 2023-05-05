using System;
using Microsoft.EntityFrameworkCore;
using User_Management_System.Models;

namespace User_Management_System.Context
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<UsersModel> users { get; set; }
	};
}

