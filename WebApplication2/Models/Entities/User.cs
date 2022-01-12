using System.ComponentModel.DataAnnotations.Schema;
using Final.Models.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace WebApplication2.Models.Entities;

public enum ServiceRoles
{
	Admin,
	Worker, 
	AccepptanceEngineer,
	AccountantEngineer
}

public class User : IdentityUser<int>, IWithId
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	
	[NotMapped]
	public string RoleName { get; set; }
	
	[NotMapped]
	public string FullName => FirstName + " " + LastName;
}