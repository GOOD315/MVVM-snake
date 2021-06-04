using UnityEngine;

namespace Code.Interface
{
    public class FoodModel : IFoodModel
    {
        public float foodPoints { get; }
        public Vector2 foodPos { get; set; }

        public FoodModel(float FoodPoints)
        {
            foodPoints = FoodPoints;
        }
    }
}