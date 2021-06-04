using Code.Snake;
using UnityEngine;

namespace Code
{
    public class SnakeFactory : ISnakeFactory
    {
        private GameObject _snakeHead;
        private GameObject _snakeTale;

        public SnakeFactory(GameObject snakeHead, GameObject snakeTale)
        {
            _snakeHead = snakeHead;
            _snakeTale = snakeTale;
        }

        public SnakeHead CreateHead()
        {
            //_snakeHead.AddComponent<Collider2D>();
            var obj = GameObject.Instantiate(_snakeHead, new Vector2(0, 0), Quaternion.identity);
            //obj.AddComponent<Collider2D>();
            var scr = obj.GetComponent<SnakeHead>();
            scr.snakeFactory = this;
            return scr;
        }

        public SnakeElem CreateTale(Vector2 pos)
        {
            // _snakeTale.AddComponent<Collider2D>();
            var obj = GameObject.Instantiate(_snakeTale, pos, Quaternion.identity);
            //obj.AddComponent<Collider2D>();
            var scr = obj.GetComponent<SnakeElem>();
            scr.snakeFactory = this;
            return scr;
        }
    }
}