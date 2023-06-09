using Service;
using UnityEngine;

namespace Game
{
    public class GameModel
    {
        public readonly Field<GameState> GameState = new Field<GameState>();
        
        public readonly Field<int> Points = new Field<int>();
        public readonly Field<int> Countdown = new Field<int>(3);
        public readonly Field<int> GameCurrency = new Field<int>();
        public readonly HealthField Health = new HealthField();

        public float Speed;
    }
}
