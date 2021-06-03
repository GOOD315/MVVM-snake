using UnityEngine;

namespace Code.Interface
{
    public interface ISnakeMoveModel
    {
        Vector3 Direction { get; }
        float Speed { get; }
    }
}