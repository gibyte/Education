namespace PatternPrototype.Tests
{
    [TestFixture]
    public class CatTests
    {
        [Test]
        public void Clone_ReturnsNewCatInstance()
        {
            // Arrange
            Cat originalCat = new Cat { Species = "Persian Cat", Age = 5, EyeColor = "Green" };

            // Act
            Cat clonedCat = originalCat.Clone();

            // Assert
            Assert.AreNotSame(originalCat, clonedCat);
            Assert.AreEqual(originalCat.Species, clonedCat.Species);
            Assert.AreEqual(originalCat.Age, clonedCat.Age);
            Assert.AreEqual(originalCat.EyeColor, clonedCat.EyeColor);
        }
    }
}
