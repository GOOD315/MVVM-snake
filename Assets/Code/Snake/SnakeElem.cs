using System;
using Code;
using UnityEngine;

public class SnakeElem : MonoBehaviour, ISnakeHandler
{
    private ISnakeHandler _nextHandler;
    public SnakeFactory snakeFactory;
    public Vector2 lastDirection;

    public void Handle(Vector2 moveDirection)
    {
        Move(moveDirection);
        _nextHandler?.Handle(lastDirection);
        lastDirection = moveDirection;
    }

    public void SetNext()
    {
        if (_nextHandler != null)
        {
            _nextHandler.SetNext();
        }
        else
        {
            CreateNew();
        }
    }

    private void CreateNew()
    {
        var pos2d = new Vector2(transform.position.x, transform.position.y);
        var spawnPlace = pos2d - lastDirection;
        _nextHandler = snakeFactory.CreateTale(spawnPlace);
    }

    private void Move(Vector2 moveDirection)
    {
        var x = transform.position.x;
        var y = transform.position.y;
        var z = transform.position.z;
        transform.position = new Vector3(x + moveDirection.x, y + moveDirection.y, z);
    }
}