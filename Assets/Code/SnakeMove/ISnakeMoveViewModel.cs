namespace Code.Interface
{
    public interface ISnakeMoveViewModel
    {
        ISnakeMoveModel _snakeMoveModel { get; }
        void Rotate();
        void Move();
    }
}