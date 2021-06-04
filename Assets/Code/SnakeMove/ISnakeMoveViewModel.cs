using UnityEngine;

namespace Code.Interface
{
    public interface ISnakeMoveViewModel
    {
        ISnakeMoveModel SnakeMoveModel { get; }
        void Rotate(Vector2 rotateVector);
        void Move(float deltaTime);
    }
}