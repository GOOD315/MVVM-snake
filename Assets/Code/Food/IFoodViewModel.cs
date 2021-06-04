namespace Code.Interface
{
    public interface IFoodViewModel
    {
        IFoodModel foodModel { get; }
        void ReSpawn();
    }
}