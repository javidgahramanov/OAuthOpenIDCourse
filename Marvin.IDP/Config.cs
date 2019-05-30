using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace Marvin.IDP
{
    public static class Config
    {
        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "85e112d1-18e7-4c03-a292-0dc2eb49300f",
                     Username = "Javid",
                     Password = "123456",
                     Claims = new List<Claim>
                     {
                         new Claim("given_name","Frank"),
                         new Claim("family_name","Underwood")
                     }
                },
                new TestUser
                {
                SubjectId = "154b670d-58a6-4b43-ad58-3fb8d4775622",
                Username = "Mamed",
                Password = "mamed123456",
                Claims = new List<Claim>
                {
                    new Claim("given_name","Mamed"),
                    new Claim("family_name","Underwood")
                }
            }

            };
        }

        public static List<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };
        }

        public static List<Client> GetClients()
        {
            return new List<Client>();
        }
    }
}
