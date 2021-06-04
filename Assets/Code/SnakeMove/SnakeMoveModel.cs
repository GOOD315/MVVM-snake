using UnityEngine;

namespace Code.Interface
{
    public class SnakeMoveModel : ISnakeMoveModel
    {
        public Vector3 Direction { get; }
        public float timeCap { get; set; }
        public float Speed { get; }

        public SnakeMoveModel(float speed)
        {
            Speed = speed;
        }
    }
}