using System;
using System.Threading;
using AzureFactory.Factory;

namespace AzureFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                // Check a message queue for direction on what to deploy.
                // In this sample we will create a WebServicePlan and 2 WebApps

                Manager.InitializeAppServicePlan();
                Manager.InitializeWebAppPlan();


                Thread.Sleep(300000); //<-- 5 minutes
            }
        }
    }
}
