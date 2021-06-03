using UnityEngine;

namespace Code.SnakeFactory
{
    public interface ISnakeFactory
    {
         GameObject Create(Sprite head);
    }
}