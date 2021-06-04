using System;
using System.Collections.Generic;
using Code.Snake;
using UnityEngine;

namespace Code.Interface
{
    public class SnakeMoveViewModel : ISnakeMoveViewModel
    {
        private Action onRotate;
        public ISnakeMoveModel SnakeMoveModel { get; }

        private SnakeHead _head;
        private Vector2 moveVector;

        public SnakeMoveViewModel(SnakeHead head, ISnakeMoveModel snakeMoveModel)
        {
            moveVector = Vector2.left;
            _head = head;
            SnakeMoveModel = snakeMoveModel;
        }

        public void Rotate(Vector2 rotateVector)
        {
            if (rotateVector != (Vector2.zero))
            {
                moveVector = rotateVector;
            }
        }

        public void Move(float time)
        {
            // периодичность вызовов - через каждые n(Speed) секунд производить действие и записывать в timeCap
            // очень коряво, знаю, не было времени придумать получше
            if (time >= SnakeMoveModel.timeCap)
            {
                SnakeMoveModel.timeCap += SnakeMoveModel.Speed;
                _head.Handle(moveVector);
            }
        }
    }
}