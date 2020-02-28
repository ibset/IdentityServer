using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer.Web.Configuration
{
    public class Config
    {
        // ApiResources define the apis in your system
        public static IEnumerable<ApiResource> GetApis()
        {
            return new List<ApiResource>
            {
                new ApiResource("persons", "Person Information Service"),
                //new ApiResource("basket", "Basket Service"),
                //new ApiResource("marketing", "Marketing Service"),
                //new ApiResource("locations", "Locations Service"),
                //new ApiResource("mobilIBSetPlataformpingagg", "Mobile Shopping Aggregator"),
                //new ApiResource("webshoppingagg", "Web Shopping Aggregator"),
                //new ApiResource("orders.signalrhub", "Ordering Signalr Hub"),
                //new ApiResource("webhooks", "Webhooks registration Service"),
            };
        }

        // Identity resources are data like user ID, name, or email address of a user
        // see: http://docs.identityserver.io/en/release/configuration/resources.html
        public static IEnumerable<IdentityResource> GetResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };
        }

        // client want to access resources (aka scopes)
        public static IEnumerable<Client> GetClients(Dictionary<string, string> clientsUrl)
        {
            return new List<Client>
            {
                // JavaScript Client
                new Client
                {
                    ClientId = "js",
                    ClientName = "IBSetPlataform SPA OpenId Client",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowAccessTokensViaBrowser = true,
                    RedirectUris =           { $"{clientsUrl["Spa"]}/" },
                    RequireConsent = false,
                    PostLogoutRedirectUris = { $"{clientsUrl["Spa"]}/" },
                    AllowedCorsOrigins =     { $"{clientsUrl["Spa"]}" },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "orders",
                        "basket",
                        "locations",
                        "marketing",
                        "webshoppingagg",
                        "orders.signalrhub",
                        "webhooks"
                    },
                },
                new Client
                {
                    ClientId = "personswaggerui",
                    ClientName = "Person Swagger UI",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowAccessTokensViaBrowser = true,

                    RedirectUris = { $"{clientsUrl["PersonApi"]}/swagger/oauth2-redirect.html" },
                    PostLogoutRedirectUris = { $"{clientsUrl["PersonApi"]}/swagger/" },

                    AllowedScopes =
                    {
                        "orders"
                    }
                }
            };
        }
    }
}