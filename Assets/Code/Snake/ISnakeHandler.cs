using System;
using UnityEngine;


    public interface ISnakeHandler
    {
        void Handle(Vector2 moveDirection);
        void SetNext();
    }
