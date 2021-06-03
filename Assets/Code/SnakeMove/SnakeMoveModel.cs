using UnityEngine;

namespace Code.Interface
{
    public class SnakeMoveModel : ISnakeMoveModel
    {
        public Vector3 Direction { get; }
        public float Speed  { get; }

        public SnakeMoveModel(float speed)
        {
            Speed = speed;
        }
    }
}