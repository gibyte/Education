namespace PatternPrototype
{
    // Класс Mammal наследует от класса Animal и реализует интерфейс IMyCloneable<Mammal>
    // Метод Clone() создает и возвращает новый объект типа Mammal, с теми же значениями свойств Species и Age, как у текущего объекта.
    // Использование ключевого слова new перед методом Clone() позволяет скрыть реализацию метода, объявленного в базовом классе Animal, и предоставить новую реализацию, специфичную для класса Mammal.
    public class Mammal : Animal, IMyCloneable<Mammal>
    {
        public int Age { get; set; }

        public new Mammal Clone()
        {
            return new Mammal { Species = this.Species, Age = this.Age };
        }
    }
}
