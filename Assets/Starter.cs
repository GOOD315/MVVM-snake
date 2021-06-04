using System;
using System.Collections;
using System.Collections.Generic;
using Code.Interface;
using Code.snakeTaleSpawner;
using UnityEngine;

namespace Code
{
    public class Starter : MonoBehaviour
    {
        [SerializeField] private FoodView FoodView;

        [SerializeField] private GameObject Food;
        [SerializeField] private GameObject SnakeHead;
        [SerializeField] private GameObject SnakeTale;
        [SerializeField] private float Speed;
        private SnakeMoveViewModel _snakeMoveViewModel;

        void Start()
        {
            var factory = new SnakeFactory(SnakeHead, SnakeTale);
            var snake = factory.CreateHead();
            var snakeSpawner = new TaleSpawner(snake);

            var moveModel = new SnakeMoveModel(Speed);
            _snakeMoveViewModel = new SnakeMoveViewModel(snake, moveModel);

            var foodModel = new FoodModel(1);
            var foodViewModel = new FoodViewModel(snake, foodModel, Food);
            FoodView.Initialize(foodViewModel);
        }


        void Update()
        {
            _snakeMoveViewModel.Move(Time.time);
            var x = Input.GetAxisRaw("Horizontal");
            var y = Input.GetAxisRaw("Vertical");
            _snakeMoveViewModel.Rotate(new Vector2(x, y));
        }
    }
}