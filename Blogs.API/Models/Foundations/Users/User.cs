using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Blogs.API.Models.Foundations.Users
{
    public class User : IdentityUser<Guid>
    {
        public override Guid Id
        {
            get => base.Id;
            set => base.Id = value;
        }

        public override string UserName
        {
            get => base.Email;
            set => base.Email = value;
        }

        public override string PhoneNumber
        {
            get => base.PhoneNumber;
            set => base.PhoneNumber = value;
        }

        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
    }
}