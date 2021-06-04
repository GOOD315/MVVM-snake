using UnityEngine;

namespace Code.Interface
{
    public interface IFoodModel
    {
        float foodPoints { get; }
        Vector2 foodPos { get; set; }
    }
}