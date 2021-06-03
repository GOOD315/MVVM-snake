using System;
using System.Collections.Generic;
using UnityEngine;

namespace Code.Interface
{
    public class SnakeMoveViewModel : ISnakeMoveViewModel
    {
        public ISnakeMoveModel _snakeMoveModel { get; }

        private GameObject _head;
        private List<GameObject> tale;

        public SnakeMoveViewModel(GameObject head, Action<object> delegat)
        {
            delegat += (object f) =>
            {
                var ff = 3;
            };
            _head = head;
        }

        public void Rotate()
        {
        }

        public void Move()
        {
        }
    }
}