using IdentityServer4;
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
                   ClientName="MvcClient",
                   ClientUri="http://localhost:5001/",
                   Description="Hellow Identity",
                   AllowRememberConsent=true,
                   LogoUri="https://image.baidu.com/search/detail?ct=503316480&z=0&ipn=d&word=.ASPnetcore&step_word=&hs=0&pn=0&spn=0&di=2420&pi=0&rn=1&tn=baiduimagedetail&is=0%2C0&istype=2&ie=utf-8&oe=utf-8&in=&cl=2&lm=-1&st=-1&cs=4083810270%2C862069733&os=2740870592%2C1132412561&simid=4049629419%2C596401338&adpicid=0&lpn=0&ln=431&fr=&fmq=1569422534597_R&fm=result&ic=&s=undefined&hd=&latest=&copyright=&se=&sme=&tab=0&width=&height=&face=undefined&ist=&jit=&cg=&bdtype=0&oriquery=&objurl=http%3A%2F%2Fres.cloudinary.com%2Fsatvasolutions-com%2Fimage%2Fupload%2Fv1499078958%2Fimgpsh_fullsize2_vnh2et_ipyvod.jpg&fromurl=ippr_z2C%24qAzdH3FAzdH3Ffwpewf5s7pt5gf_z%26e3Bv54AzdH3Ffj6etvjfAzdH3Fwfr-gjp-v56j-1jejs5r4jgp-v54rwgyAzdH3F&gsm=&rpstart=0&rpnum=0&islist=&querylist=&force=undefined",
                   AllowedGrantTypes=GrantTypes.Implicit,
                   ClientSecrets={
                       new Secret("secret".Sha256())
                       },
                   //是否需要Consent页面
                   RequireConsent=true,
                   RedirectUris={ "http://localhost:5001/signin-oidc"},
                   PostLogoutRedirectUris={ "http://localhost:5001/signout-callback-oidc" },
                   AllowedScopes={
                       IdentityServerConstants.StandardScopes.Profile,
                       IdentityServerConstants.StandardScopes.OpenId,
                       IdentityServerConstants.StandardScopes.Email,
                   }
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
