using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aria.SDK.SystemFramework.ConfigFactory;

namespace ConfigFactoryTest
{
  /// <summary>
  ///This is a test class for ConfigFactoryTest and is intended
  ///to contain all ConfigFactoryTest Unit Tests
  ///</summary>
  [TestClass()]
  public class ConfigFactoryTest
  {
    private TestContext testContextInstance;

    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext
    {
      get
      {
        return testContextInstance;
      }
      set
      {
        testContextInstance = value;
      }
    }

    #region Additional test attributes

    // 
    //You can use the following additional attributes as you write your tests:
    //
    //Use ClassInitialize to run code before running the first test in the class
    //[ClassInitialize()]
    //public static void MyClassInitialize(TestContext testContext)
    //{
    //}
    //
    //Use ClassCleanup to run code after all tests in a class have run
    //[ClassCleanup()]
    //public static void MyClassCleanup()
    //{
    //}
    //
    //Use TestInitialize to run code before running each test
    //[TestInitialize()]
    //public void MyTestInitialize()
    //{
    //}
    //
    //Use TestCleanup to run code after each test has run
    //[TestCleanup()]
    //public void MyTestCleanup()
    //{
    //}
    //

    #endregion


    /// <summary>
    ///A test for GetAriaAuthorizationKey
    ///</summary>
    [TestMethod()]
    public void GetAriaAuthorizationKeyTest()
    {
      Assert.IsNotNull(ConfigurationManager.AppSettings[ConfigFactory_Accessor.ARIA_AUTHORIZATION_KEY], "Authorization key not found in config file");
      Assert.AreEqual(ConfigurationManager.AppSettings[ConfigFactory_Accessor.ARIA_AUTHORIZATION_KEY],
                      ConfigFactory.GetAriaAuthorizationKey());
    }

    ///<summary>
    ///A test for GetAriaClientNumber
    ///</summary>
    [TestMethod()]
    public void GetAriaClientNumberTest()
    {
      Assert.IsNotNull(ConfigurationManager.AppSettings[ConfigFactory_Accessor.ARIA_CLIENT_NUMBER], "client number key not found in config file");
      Assert.AreEqual(Convert.ToInt64(ConfigurationManager.AppSettings[ConfigFactory_Accessor.ARIA_CLIENT_NUMBER]),
                      ConfigFactory.GetAriaClientNumber());
    }
  }
}