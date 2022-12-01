using Microsoft.AspNetCore.Identity;
using WebApplication2.Models.Interfaces;

namespace WebApplication2.Models.Entities;

public class Role : IdentityRole<int>, IWithId
{
}