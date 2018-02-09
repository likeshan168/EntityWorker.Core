﻿using EntityWorker.Core.Attributes;

namespace LightData.CMS.Modules.Library
{
    public class User
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public System.Guid RoleId { get; set; }

        public Role Role { get; set; }

        public System.Guid PersonId { get; set; }

        public Person Person { get; set; }

    }
}