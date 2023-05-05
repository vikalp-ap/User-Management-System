using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace User_Management_System.Models
{
	public class UsersModel
	{
        [Column("id")]
        public int Id { get; set; }
        [Column("age")]
        public int Age { get; set; }
        [Column("name")]
        public string? Name { get; set; }
        [Column("email")]
        public string? Email { get; set; }
    }
}

