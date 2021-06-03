using UnityEngine;

namespace Code.SnakeFactory
{
    public class SnakeFactory : ISnakeFactory
    {
        public GameObject Create(Sprite head)
        {
            var snake = GameObject.Instantiate(head, new Vector3(5, 5, 0), Quaternion.identity);
            return new GameObject();
        }
    }
}