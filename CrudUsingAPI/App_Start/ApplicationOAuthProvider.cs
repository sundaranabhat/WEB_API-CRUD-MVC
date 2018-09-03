using Microsoft.Owin.Security.OAuth;

namespace CrudUsingAPI
{
    internal class ApplicationOAuthProvider : IOAuthAuthorizationServerProvider
    {
        private string publicClientId;

        public ApplicationOAuthProvider(string publicClientId)
        {
            this.publicClientId = publicClientId;
        }
    }
}