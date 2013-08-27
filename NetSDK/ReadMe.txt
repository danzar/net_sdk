NOTE: This SDK is only compatible with Visual Studio 2010.
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

Configure the build script:
In AriaSDK.build:
	1. set up the property name="wsdlURL" value to the complete-doc_literal.wsdl address.
set the endpointAddress to the class dispatcher.
	2. modify the property name="solution.dir" value to point to the solution directory on the build machine.
	3. modify the property name="devenv.dir" value to point to the directory where the devenv executeable resides on the build machine.

Run Go.Bat - You may need to do this as an administrator if on Vista or Windows 7 (open command prompt as administrator, navigate to directory containing go.bat and then execute this bat file)
it will run the build process in ARIASDK.Build
If the build passes it will let you know, otherwise the error will be output to the command prompt.
Upon successfull completion, the build/Release/dist folder will contain the installer msi.
