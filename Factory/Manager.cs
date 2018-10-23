using System;
using AzureFactory.Models;
using Microsoft.Azure.Management;

namespace AzureFactory.Factory
{
    public static class Manager
    {
        public static AzureFactoryResponse InitializeAppServicePlan()
        {
            //Microsoft.Azure.Management.AppService.Fluent.Models.AppServicePlanRestrictions.Free
            

            return new AzureFactoryResponse{isSuccess = true};
        }  

        public static AzureFactoryResponse InitializeWebApp()
        {
            //Microsoft.Azure.Management.AppService.Fluent.Models.AppServicePlanRestrictions.Free
            

            return new AzureFactoryResponse{isSuccess = true};
        }  
    }
}