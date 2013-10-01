Aria .net SDK
==============
Setup Instructions:
-------------------
1.	Generate the supporting CS files for REST mode of SDK using SDK Generator.
2.	Download this GitHub repository and ensure that we are running Visual Studio 2010 or 2012.
3.	The generated file for the .Net language will have to be unzipped. Move the unzipped "AriaBillingComplete.cs" and "RestUtilities.cs" to the AriaRestClient and the "AriaCompleteTest.cs" to the AriaRestClientTest projects in order to update the existing classes of previous wsdl version.
4.	The library generation has to be done following the instructions on the [Readme.txt] file included on the NetSDK folder. This happens because is unnecessary to generate the libraries when the user has also to update the service reference on his own project inside the visual studio solution.
5.	The generated library files (AriaWebService.DLL and AriaRestClient.DLL) are available inside the "build" folder.
6.	To test FullReg and FreeReg, copy the library files in build folder and put them in   library/AriaSDK in FreeReg or FullReg solution directory.
7.	Open the solution file in Visual Studio 2012 Build it also build installer project also.
8.	By executing Installer files (reside in all client application folder) host the application in IIS 
9.	Then open the application URL in browser.
10.	Open the solution file in Visual Studio 2010 Build it and run.

Note 1: For .NetSDK we must use "complete-doc_literal_wrapped.wsdl" in both Java SDK generator (step1) and build file (refer step4). If we used some other WSDL file it will show runtime issues due to missing namespace declaration.
E.g.: Wrapped WSDL to use - https://secure.future.stage.ariasystems.net/api/Advanced/wsdl/6.10/complete-doc_literal_wrapped.wsdl

Note 2: After new change in any application build the installer file to affect the changes in case after building installer file it was not updated properly means change the output path for installer project by using visual studio 2012.
Right click installer project-> Select Property ->select build tab in newly opened window -> change the output path and save it 
Then once again build installer application.

 
Build file
----------
1.	In build file (resides in NetSDK folder as AriaSDK.build) we need to mention the Application path; Visual studio 2010 installed path and wrapped WSDL path (either the local path or web URL).
2.	In build file, the "regenerate-from-wsdl" block contains commands to generate the Reference.cs file using given WSDL URL using SvcUtil.exe (visual studio utility function).
3.	Reference.cs file gets copied to both AriaRestClient and AriaWebService service reference path.
Reference.cs files contains definition of each API call's parameter and return types. It also has the service contract definitions.
4.	"clean" block contains commands to delete build folder finally.
5.	"compile" block contain commands to get the configuration elements from app.config file and build the solution using Nant tool.
Nant Tool resides in tools folder inside of NetSDK folder.


