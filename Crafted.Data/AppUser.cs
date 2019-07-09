﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Crafted.Data
{
    // Add profile data for application users by adding properties to this class
    public class AppUser : IdentityUser
    {
        // Extended Properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public long? FacebookId { get; set; }

        public long? GoogleId  { get; set; }

        public string PictureUrl { get; set; }

        public ICollection<AppUserTable> AppUserTables { get; set; }

    }
}
