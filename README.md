Aria .net SDK
==============
Build Instructions:
-------------------
1.	The C# files "AriaBillingComplete.cs" and "RestUtilities.cs" for REST mode of SDK are generated and updated in GitHub (under NetSDK\src\AriaRestClient) on every release.
2.	Similarly, the test class "AriaCompleteTest.cs" is updated in GitHub (under NetSDK\src\AriarestClientTest) on every release.
3.	The library generation has to be done following the instructions on the [Readme.txt] file included on the NetSDK folder.
4.	The generated library files (AriaWebService.DLL and AriaRestClient.DLL) will be available inside the "NetSDK\build" folder.
5.	Import these DLLs to your own .NET project and call the desired API in REST or SOAP mode by using the corresponding "AriaCompleteTest" class.
6.	Please refer to the "AriaCompleteTest.cs" to understand how to call the APIs and how to consume the response.
7.	Sample code below:

       /* Use REST or SOAP's AriaBillingComplete class */

       public static AriaBillingComplete mService = new AriaBillingComplete(ConfigurationManager.AppSettings[ARIA_DISPATCHER_URL]);

       get_client_itemsRequest request = new get_client_itemsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            filter_currency_cd = "",
            return_no_cost_items = "",
            filter_item_no = 1
            };

        var response = mService.get_client_items(request);

8.	The repository also has two web applications that explains how these SDK libraries can be used in web applications. The usage of it is explained below.

Using Regn web apps:
--------------------
5.	To test FullReg and FreeReg web applications, copy the above generated library files to library/AriaSDK in FreeReg and FullReg solution directory.
6.	Open the solution file in Visual Studio 2012 and build it (build the installer project also if any component is modified).
7.	By executing Installer (that resides in all client application folder) host the application in IIS 
8.	Then open the application URL in browser and observe the account registration wizard.
