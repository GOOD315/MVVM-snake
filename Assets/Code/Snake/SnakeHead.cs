using System;
using Code.Interface;
using UnityEngine;

namespace Code.Snake
{
    public class SnakeHead : SnakeElem
    {
        public Action onDead;
        public Action onEat;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.TryGetComponent<SnakeElem>(out var g))
            {
                onDead?.Invoke();
                Debug.Log("PROIGRAL");
            }

            if (other.gameObject.TryGetComponent<Food>(out var food))
            {
                onEat?.Invoke();
            }
        }
    }
}