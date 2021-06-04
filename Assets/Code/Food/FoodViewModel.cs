using System;
using Code.Snake;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Code.Interface
{
    public class FoodViewModel : MonoBehaviour, IFoodViewModel
    {
        private GameObject _food;
        public IFoodModel foodModel { get; }

        public FoodViewModel(SnakeHead snakeHead, IFoodModel foodModel, GameObject food)
        {
            this.foodModel = foodModel;
            snakeHead.onEat += ReSpawn;


            var randomX = Random.Range(-15, 15);
            var randomY = Random.Range(-15, 15);
            _food = Instantiate(food, new Vector2(randomX, randomY), quaternion.identity);
        }


        public void ReSpawn()
        {
            var randomX = Random.Range(-15, 15);
            var randomY = Random.Range(-15, 15);
            _food.transform.position = new Vector3(randomX, randomY, 0);
        }
    }
}