using Game;
using UnityEngine;

namespace GameCurrency
{
    public class GameCurrencyAnimationComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private Animator _animator;
        private static readonly int Show = Animator.StringToHash("Show");
        
        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
                
            _animator.SetTrigger(Show);
        }
    }
}