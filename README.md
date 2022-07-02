# GraphApiConsoleApp
Simple example of how to use Graph API with an AD registered application.

Step 1: Register your application
To register your application and add the app's registration information to your solution manually, follow these steps:

Sign in to the Azure portal.
If you have access to multiple tenants, use the Directories + subscriptions filter  in the top menu to switch to the tenant in which you want to register the application.
Search for and select Azure Active Directory.
Under Manage, select App registrations > New registration.
For Name, enter a name for your application. For example, enter Daemon-console. Users of your app will see this name, and you can change it later.
Select Register to create the application.
Under Manage, select Certificates & secrets.
Under Client secrets, select New client secret, enter a name, and then select Add. Record the secret value in a safe location for use in a later step.
Under Manage, select API Permissions > Add a permission. Select Microsoft Graph.
Select Application permissions.
Under the User node, select User.Read.All, and then select Add permissions.
