using Code.Interface;
using Code.Snake;

namespace Code.snakeTaleSpawner
{
    public class TaleSpawner
    {
        private ISnakeMoveViewModel _snakeMoveViewModel;
        private SnakeHead _snakeHead;

        public TaleSpawner(SnakeHead head)
        {
            _snakeHead = head;
            head.onEat += SpawnTale;
        }

        public void SpawnTale()
        {
            _snakeHead.SetNext();
        }
    }
}