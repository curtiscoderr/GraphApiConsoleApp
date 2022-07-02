# GraphApiConsoleApp
Simple example of how to use Graph API with an AD registered application.
------------------------------------------------------------------------------------------------------------------------------------------
<https://docs.microsoft.com/en-us/azure/active-directory-b2c/microsoft-graph-get-started?tabs=app-reg-ga#register-management-application> 
------------------------------------------------------------------------------------------------------------------------------------------
Register management application
-------------------------------

Before your scripts and applications can interact with the [Microsoft Graph API](https://docs.microsoft.com/en-us/graph/api/overview) to manage Azure AD B2C resources, you need to create an application registration in your Azure AD B2C tenant that grants the required API permissions.

1.  Sign in to the [Azure portal](https://portal.azure.com/).
2.  Make sure you're using the directory that contains your Azure AD B2C tenant. Select the Directories + subscriptions icon in the portal toolbar.
3.  On the Portal settings | Directories + subscriptions page, find your Azure AD B2C directory in the Directory name list, and then select Switch.
4.  In the Azure portal, search for and select Azure AD B2C.
5.  Select App registrations, and then select New registration.
6.  Enter a Name for the application. For example, *managementapp1*.
7.  Select Accounts in this organizational directory only.
8.  Under Permissions, clear the *Grant admin consent to openid and offline_access permissions* check box.
9.  Select Register.
10. Record the Application (client) ID that appears on the application overview page. You use this value in a later step.

Create Secret
----------------
1.  Under Manage, select Certificates & secrets.
2.  Select New client secret.
3.  Enter a description for the client secret in the Description box. For example, *clientsecret1*.
4.  Under Expires, select a duration for which the secret is valid, and then select Add.
5.  Record the secret's Value. You use this value for configuration in a later step.

Grant API access
----------------
1.  Under Manage, select API permissions.
2.  Under Configured permissions, select Add a permission.
3.  Select the Microsoft APIs tab, then select Microsoft Graph.
4.  Select Application permissions.
5.  Expand the appropriate permission group and select the check box of the permission to grant to your management application. For example:
    -   User > User.ReadWrite.All: For user migration or user management scenarios.
    -   Group > Group.ReadWrite.All: For creating groups, read and update group memberships, and delete groups.
    -   AuditLog > AuditLog.Read.All: For reading the directory's audit logs.
    -   Policy > Policy.ReadWrite.TrustFramework: For continuous integration/continuous delivery (CI/CD) scenarios. For example, custom policy deployment with Azure Pipelines.
6.  Select Add permissions. As directed, wait a few minutes before proceeding to the next step.
7.  Select Grant admin consent for (your tenant name).
8.  If you are not currently signed-in with Global Administrator account, sign in with an account in your Azure AD B2C tenant that's been assigned at least the *Cloud application administrator* role and then select Grant admin consent for (your tenant name).
9.  Select Refresh, and then verify that "Granted for ..." appears under Status. It might take a few minutes for the permissions to propagate.
