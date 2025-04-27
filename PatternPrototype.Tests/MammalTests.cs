using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrototype.Tests
{
    [TestFixture]
    public class MammalTests
    {
        [Test]
        public void Clone_ReturnsNewMammalInstance()
        {
            // Arrange
            Mammal originalMammal = new Mammal { Species = "Elephant", Age = 20 };

            // Act
            Mammal clonedMammal = originalMammal.Clone();

            // Assert
            Assert.AreNotSame(originalMammal, clonedMammal);
            Assert.AreEqual(originalMammal.Species, clonedMammal.Species);
            Assert.AreEqual(originalMammal.Age, clonedMammal.Age);
        }
    }
}
