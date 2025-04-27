namespace PatternPrototype.Tests
{
    [TestFixture]
    public class AnimalTests
    {
        [Test]
        public void Clone_IMyCloneable_ReturnsNewAnimalInstance()
        {
            // Arrange
            Animal originalAnimal = new() { Species = "Lion" };

            // Act
            Animal clonedAnimal = originalAnimal.Clone();

            // Assert
            Assert.AreNotSame(originalAnimal, clonedAnimal);
            Assert.AreEqual(originalAnimal.Species, clonedAnimal.Species);
        }

        [Test]
        public void Clone_ICloneable_ReturnsNewAnimalInstance()
        {
            // Arrange
            Animal originalAnimal = new Animal { Species = "Tiger" };

            // Act
            Animal clonedAnimal = (Animal)((ICloneable)originalAnimal).Clone();

            // Assert
            Assert.AreNotSame(originalAnimal, clonedAnimal);
            Assert.AreEqual(originalAnimal.Species, clonedAnimal.Species);
        }
    }
}
