using Azure.Identity;
using Microsoft.Graph;

namespace GraphApiConsoleApp
{
    public static class Program
    {
        static async Task Main(string[] args)
        {
            // Initialize the client credential auth provider
            var scopes = new[] { "https://graph.microsoft.com/.default" };

            // TenantId, AppId, Clientsecret
            // 92a69b77-0a9a-497c-bae0-d8d67e6dd8a7
            // app id: 61d91a89-cfc3-4066-9983-96b74f5c871e
            // secret: 
            var clientSecretCredential = new ClientSecretCredential("92a69b77-0a9a-497c-bae0-d8d67e6dd8a7", "61d91a89-cfc3-4066-9983-96b74f5c871e", "");
            var graphClient = new GraphServiceClient(clientSecretCredential, scopes);
            var user = await graphClient.Users["c4ae1c53-8b93-446c-a358-6c08265698ed"]
                .Request()
                .Select("givenName,surName,Id,Identities")
                .GetAsync();

            Console.WriteLine(user.Surname);

            user.Surname = "NewLastName";

            await graphClient.Users["c4ae1c53-8b93-446c-a358-6c08265698ed"]
                .Request()
                .UpdateAsync(user);


            user.Surname = "Weber";

           await graphClient.Users["c4ae1c53-8b93-446c-a358-6c08265698ed"]
                .Request()
                .UpdateAsync(user);
        }
    }
}