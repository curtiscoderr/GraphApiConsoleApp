# GraphApiConsoleApp
Simple example of how to use Graph API with an AD registered application.

([https://docs.microsoft.com/en-us/azure/active-directory/develop/console-app-quickstart?pivots=devlang-dotnet-core](https://docs.microsoft.com/en-us/azure/active-directory/develop/console-app-quickstart?pivots=devlang-dotnet-core#step-1-register-your-application))
#### Step 1: Register your application

To register your application and add the app's registration information to your solution manually, follow these steps:

1.  Sign in to the [Azure portal](https://portal.azure.com/).
2.  If you have access to multiple tenants, use the Directories + subscriptions filter ![](https://docs.microsoft.com/en-us/azure/active-directory/develop/media/common/portal-directory-subscription-filter.png) in the top menu to switch to the tenant in which you want to register the application.
3.  Search for and select Azure Active Directory.
4.  Under Manage, select App registrations > New registration.
5.  For Name, enter a name for your application. For example, enter Daemon-console. Users of your app will see this name, and you can change it later.
6.  Select Register to create the application.
7.  Under Manage, select Certificates & secrets.
8.  Under Client secrets, select New client secret, enter a name, and then select Add. Record the secret value in a safe location for use in a later step.
9.  Under Manage, select API Permissions > Add a permission. Select Microsoft Graph.
10. Select Application permissions.
11. Under the User node, select User.Read.All, and then select Add permissions.

#### [](https://docs.microsoft.com/en-us/azure/active-directory/develop/console-app-quickstart?pivots=devlang-dotnet-core#step-2-download-your-visual-studio-project)Step 2: Download your Visual Studio project
