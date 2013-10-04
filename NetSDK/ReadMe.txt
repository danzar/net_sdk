NOTE: This SDK is only compatible with Visual Studio 2010 and 2012.
Setting up the solution environment:
Set up an iis virtual directory for http://Localhost/AriaSampleApps2010 and have its directory be src/UIProjects/AriaSampleApps
Convert this directory to an application.
In order for this virtual directory to work you must install the following IIS components:

      IIS 6 Metabase and IIS 6 Configuration Compatibility
      ASP.NET

In addition, you must run Visual Studio in the context of an administrator account.

In the Web.config (located in \src\UIProjects\AriaSampleApps):
Please make sure valid values for the following keys are present (below values are an example, but may be different):
<add key="aria-client-number" value="38000" />
<add key="aria-authorization-key" value="tmENa76cwceNqeRKekBBf9WXBgETEtNT" />

WSDL:
-----
1. For .NetSDK we must use "complete-doc_literal_wrapped.wsdl" format.
   Sample wrapped WSDL to use - https://secure.future.stage.ariasystems.net/api/Advanced/wsdl/6.10/complete-doc_literal_wrapped.wsdl
2. Download the wsdl and replace all occurrences of 'minOccurs="0"' with 'nillable="true" minOccurs="0"'. This is because the SVCUtil does not create object references with nullable datatype if nillable attribute with value of 'true' is missing.
3. So for example, the following element,
<xsd:element name="billable_acct_no" type="xsd:long" minOccurs="0" maxOccurs="1"/>
will become,
<xsd:element name="billable_acct_no" type="xsd:long" nillable="true" minOccurs="0" maxOccurs="1"/>


Configure the build script:
---------------------------
In AriaSDK.build:
	1. set up the property name="wsdlURL" value to the above complete-doc_literal_wrapped.wsdl address.
	2. set the "endpointAddress" to the class dispatcher, ex: https://secure.future.stage.ariasystems.net/api/ws/api_ws_class_dispatcher.php.
	3. modify the property name="solution.dir" value to point to the solution directory on the build machine.
	4. modify the property name="devenv.dir" value to point to the directory where the devenv executeable resides on the build machine.

Run Go.Bat - You may need to do this as an administrator if on Vista or Windows 7 (open command prompt as administrator, navigate to directory containing go.bat and then execute this bat file)
it will run the build process in ARIASDK.Build
If the build passes it will let you know, otherwise the error will be output to the command prompt.
Upon successfull completion, the build/Release/dist folder will contain the installer msi.

Build file
----------
1.	In build file (that resides in NetSDK folder as AriaSDK.build) we need to mention the Application path; Visual studio 2010 installed path and wrapped WSDL path (either the local path or web URL).
2.	In build file, the "regenerate-from-wsdl" block contains commands to generate the Reference.cs class file using given WSDL URL using SvcUtil.exe (visual studio utility function).
3.	Reference.cs file gets copied to both AriaRestClient and AriaWebService service reference path.
Reference.cs files contains definition of each API call's parameter and return types. It also has the service contract definitions.
4.	"compile" block contain commands to get the configuration elements from app.config file and build the solution using Nant tool. Nant Tool resides in tools folder inside the NetSDK folder.

Installer:
----------
After new change in any application build the installer file to affect the changes in case after building installer file it was not updated properly means change the output path for installer project by using visual studio 2012.
Right click installer project-> Select Property ->select build tab in newly opened window -> change the output path and save it 
Then once again build installer application.
