using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;
using IdentityServer4.Services;
using IdentityServer4.Stores;
using Microsoft.AspNetCore.Mvc;
using MvcCookieSample.ViewModels;

namespace MvcCookieSample.Controllers
{
    public class ConsentController : Controller
    {
        private readonly IClientStore _clientStore;
        private readonly IResourceStore _resourceStore;
        private readonly IIdentityServerInteractionService _identityServerInteractionService;
        public ConsentController(IClientStore clientStore, IResourceStore resourceStore, IIdentityServerInteractionService identityServerInteractionService)
        {
            _clientStore = clientStore;
            _resourceStore = resourceStore;
            _identityServerInteractionService = identityServerInteractionService;
        }
        public async Task<IActionResult> Index(string returnUrl)
        {
            var model = await BuildConsentViewModel(returnUrl);
            if (model==null)
            {

            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(InputConsentViewModel model)
        {
           
            return View();
        }
        private async Task<ConsentViewModel> BuildConsentViewModel(string returnUrl)
        {
            var request = await _identityServerInteractionService.GetAuthorizationContextAsync(returnUrl);
            if (request == null)
                return null;
            var client = await _clientStore.FindEnabledClientByIdAsync(request.ClientId);
            var resources = await _resourceStore.FindEnabledResourcesByScopeAsync(request.ScopesRequested);
            return CreateConsentViewModel(request, client, resources);
        }
        private ConsentViewModel CreateConsentViewModel(AuthorizationRequest request,Client client,Resources resources)
        {
            var vm = new ConsentViewModel()
            {
               ClientName = client.ClientName,
               ClientLogoUrl = client.LogoUri,
               ClientUrl=client.ClientUri,
               AllowRememberConsent=client.AllowRememberConsent,
               IdentityScopes=resources.IdentityResources.Select(i=>CreateScopeViewModel(i)),
               ResourceScopes=resources.ApiResources.SelectMany(i => i.Scopes).Select(x=> CreateScopeViewModel(x))

            };
            return vm;
        }
        private ScopeViewModel CreateScopeViewModel(IdentityResource identityResource)
        {
            return new ScopeViewModel()
            {
                Name= identityResource.Name,
                DisplayName=identityResource.DisplayName,
                Descripton=identityResource.Description,
                Required=identityResource.Required,
                Checked=identityResource.Required,
                Emphasize=identityResource.Emphasize
            };
        }
        private ScopeViewModel CreateScopeViewModel(Scope scope)
        {
            return new ScopeViewModel()
            {
                Name = scope.Name,
                DisplayName = scope.DisplayName,
                Descripton = scope.Description,
                Required = scope.Required,
                Checked = scope.Required,
                Emphasize = scope.Emphasize
            };
        }

    }
}