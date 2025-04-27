namespace PatternPrototype
{
    // Интерфейс IMyCloneable<T> определяет один метод Clone(), который должен возвращать объект типа T.
    interface IMyCloneable<T>
    {
        T Clone();
    }
}
