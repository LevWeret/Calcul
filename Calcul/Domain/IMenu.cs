namespace Domain
{
    public interface IMenu<out T>
    {
        IMenu<T> Show();
        IMenuItemSelector<T> ItemSelector { get; }
    }
}
