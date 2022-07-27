using dotnet_demo_project;
using dotnet_demo_project.Utility;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ValidEmail()
        {
            EmailManager manager = new EmailManager();
            var result = manager.IsValidAddress("test@domain.com");
            Assert.True(result);
        }
    }
}