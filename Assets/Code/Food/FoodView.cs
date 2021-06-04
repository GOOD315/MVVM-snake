using System;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Interface
{
    public class FoodView : MonoBehaviour, IFoodView
    {
        [SerializeField] private Text scoreText;
        public IFoodViewModel _foodViewModel { get; set; }

        private void Start()
        {
            scoreText.text = "0";
        }

        private void AddScore()
        {
            scoreText.text = (Int32.Parse(scoreText.text) + 1).ToString();
        }

        public void Initialize(IFoodViewModel foodViewModel)
        {
            _foodViewModel = foodViewModel;
        }
    }
}