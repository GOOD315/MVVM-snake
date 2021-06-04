using UnityEngine;

namespace Code.Interface
{
    public class SnakeMoveView : ISnakeMoveView
    {
        private ISnakeMoveViewModel _snakeMoveViewModel;
        
        public void Initialize(ISnakeMoveViewModel snakeMoveViewModel)
        {
            _snakeMoveViewModel = snakeMoveViewModel;
        }

        private void Rotate()
        {
            
        }
    }
}