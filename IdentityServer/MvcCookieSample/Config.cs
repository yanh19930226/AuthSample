using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCookieSample
{
    public class Config
    {
        //获取资源
        public static IEnumerable<IdentityResource> GetIdentityResource()
        {
            return new List<IdentityResource>{
               new IdentityResources.OpenId(),
               new IdentityResources.Profile(),
               new IdentityResources.Email(),
           };
        }
        //获取资源
        public static IEnumerable<ApiResource> GetResource()
        {
            return new List<ApiResource>{
               new ApiResource("api","MyApi")
           };
        }
        //获取客户端
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>{
               new Client{
                   ClientId="mvc",
                   AllowedGrantTypes=GrantTypes.Implicit,
                   ClientSecrets={
                       new Secret("secret".Sha256())
                       },
                   AllowedScopes={ "api" }
               }
           };
        }
        //测试用户
        public static List<TestUser> GetTestUsers()
        {
            return new List<TestUser>()
            {
                new TestUser(){
                    SubjectId="1",
                    Username="yanh",
                    Password="123456"
                }
            };
        }
    }
}
