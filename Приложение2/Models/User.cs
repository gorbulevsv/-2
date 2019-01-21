using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Приложение2.Models
{
    public class User:IdentityUser
    {
        public int Год { get; set; }
    }
}
