using NUnit.Framework;
using src;

namespace tests
{
    public class CharacterShould
    {
        [Test]
        public void Damage_Another_Character()
        {
            Assert.AreEqual(expectedHealth, character2.Health);
        }
    }
}