using System.Collections;
using System.Collections.Generic;
using Code.Interface;
using Code.SnakeFactory;
using UnityEngine;

public class Starter : MonoBehaviour
{
    [SerializeField] private Sprite SnakeHead;
    [SerializeField] private float Speed;

    void Start()
    {
        var factory = new SnakeFactory();
        var snake = factory.Create(SnakeHead);


        var moveModel = new SnakeMoveModel(Speed);
        //var moveViewModel = new SnakeMoveViewModel(SnakeHead);
    }

    // Update is called once per frame
    void Update()
    {
    }
}

public class ff
{
    static void FF()
    {
        Debug.Log("ff");
    }
}