namespace PatternPrototype
{
    //Класс Cat наследует от класса Mammal и реализует интерфейс IMyCloneable<Cat>.
    //Он представляет кошку и имеет дополнительное свойство EyeColor, которое хранит цвет глаз кошки.
    //Метод Clone() создает и возвращает новый объект типа Cat с такими же значениями свойств Species, Age и EyeColor.
    //Использование ключевого слова new перед методом Clone() указывает на то, что это новая реализация метода для данного класса.
    public class Cat : Mammal, IMyCloneable<Cat>
    {
        public string EyeColor { get; set; }

        public new Cat Clone()
        {
            return new Cat { Species = this.Species, Age = this.Age, EyeColor = this.EyeColor };
        }
    }
}
