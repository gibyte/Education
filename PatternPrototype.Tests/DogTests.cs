namespace PatternPrototype.Tests
{
    [TestFixture]
    public class DogTests
    {
        [Test]
        public void Clone_ReturnsNewDogInstance()
        {
            // Arrange
            Dog originalDog = new Dog { Species = "Golden Retriever", Age = 3, Breed = "Labrador" };

            // Act
            Dog clonedDog = originalDog.Clone();

            // Assert
            Assert.AreNotSame(originalDog, clonedDog);
            Assert.AreEqual(originalDog.Species, clonedDog.Species);
            Assert.AreEqual(originalDog.Age, clonedDog.Age);
            Assert.AreEqual(originalDog.Breed, clonedDog.Breed);
        }
    }
}
