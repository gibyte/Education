namespace PatternPrototype
{
    // Класс Dog наследует от класса Mammal и реализует интерфейс IMyCloneable<Dog>
    // В классе Dog определен метод Clone(), который создает и возвращает новый объект типа Dog.
    // Этот метод использует ключевое слово new, чтобы указать, что это новая реализация метода для данного класса.
    // Внутри метода создается новый объект Dog с такими же значениями свойств Species, Age и Breed, как у текущего объекта.
    // Таким образом, клонированный объект будет иметь те же характеристики, что и оригинальный.
    public class Dog : Mammal, IMyCloneable<Dog>
    {
        public string Breed { get; set; }

        public new Dog Clone()
        {
            return new Dog { Species = this.Species, Age = this.Age, Breed = this.Breed };
        }
    }
}
