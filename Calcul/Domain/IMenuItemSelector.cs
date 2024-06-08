namespace Domain
{
    public interface IMenuItemSelector<out T>
    {
        T Select();
    }
}