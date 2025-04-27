namespace PatternPrototype
{
    // Класс Animal представляет базовую сущность животного.
    // Он реализует два интерфейса: IMyCloneable<Animal> и ICloneable.
    // У класса есть свойство Species, которое определяет вид животного.
    // Метод Clone() возвращает новый объект того же класса Animal с тем же значением свойства Species.
    // Реализация метода Clone() интерфейса ICloneable делегирует вызов к уже существующему методу Clone() данного класса.
    public class Animal : IMyCloneable<Animal>, ICloneable
    {
        public string Species { get; set; }

        public Animal Clone()
        {
            return new Animal { Species = this.Species };
        }
        object ICloneable.Clone()
        {
            return this.Clone();
        }
    }
}