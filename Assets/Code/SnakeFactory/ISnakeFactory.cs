using Code.Snake;
using UnityEngine;

namespace Code
{
    public interface ISnakeFactory
    {
        SnakeHead CreateHead();
        SnakeElem CreateTale(Vector2 pos);
    }
}