using UnityEngine;

namespace Code.Interface
{
    public interface ISnakeMoveModel
    {
        Vector3 Direction { get; }
        float timeCap { get; set; }
        float Speed { get; }
    }
}