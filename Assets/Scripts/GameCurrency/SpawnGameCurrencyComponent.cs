using System.Collections;
using System.Collections.Generic;
using Game;
using HealthBar;
using UnityEngine;

namespace GameCurrency
{
    public class SpawnGameCurrencyComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private Transform _pointSpawn;
        [SerializeField] private GameObject _gameCurrency;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;

            StartCoroutine(SpawnAdditionalHealth());
        }

        private IEnumerator SpawnAdditionalHealth()
        {
            while (true)
            {
                var gameState = _gameModel.GameState.Value;

                if (gameState == GameState.Playing)
                {
                    yield return new WaitForSeconds(5);
                    
                    var newGameCurrency = Instantiate(_gameCurrency, _pointSpawn.transform.position,
                        Quaternion.identity);

                    var moveGameCurrency = newGameCurrency.GetComponent<MoveGameCurrencyComponent>();
                    var triggerGameCurrency = newGameCurrency.GetComponent<TriggerGameCurrencyComponent>();
                    var animationGameCurrency = newGameCurrency.GetComponent<GameCurrencyAnimationComponent>();

                    moveGameCurrency.Initialize(_gameModel, _gameScene);
                    triggerGameCurrency.Initialize(_gameModel, _gameScene);
                    animationGameCurrency.Initialize(_gameModel, _gameScene);
                }

                yield return null;
            }
        }
    }
}