using Operations.SecurityOperations;

namespace Operations.Tests
{
    [TestClass()]
    public class SecurityOpertatorTests
    {        

        [TestMethod()]
        public void EncrypteTest()
        {
            var SecOp = new SecurityOperator();

            var plainText = "hello world";
            var key = "myKey";

            var cypherText = SecOp.Encryptor(plainText,key);
            var decryptedText = SecOp.Decryptor(cypherText, key);

            Assert.AreEqual(plainText, decryptedText);
        }
    }
}