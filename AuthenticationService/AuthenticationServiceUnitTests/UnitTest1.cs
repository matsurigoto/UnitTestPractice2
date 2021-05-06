using AuthenticationService;
using NUnit.Framework;

namespace AuthenticationServiceUnitTests
{
    [TestFixture]
    public class AuthenticationServiceTests
    {
        [Test()]
        public void is_valid()
        {
            var target = new AuthenticationServices();

            var actual = target.IsValid("Duran", "12000000");

            //always failed
            Assert.IsTrue(actual);
        }
    }
}