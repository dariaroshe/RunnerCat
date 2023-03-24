using Background;
using Barriers;
using Buttons;
using Platforms;
using Player;
using Points;
using Popups;
using UnityEngine;
using UnityEngine.UIElements;

namespace Game
{
    public class GameScene : MonoBehaviour
    {
        public StartGameComponent StartGameComponent;
        public StartGameTextComponent StartGameTextComponent;
        
        public RunPlayerComponent RunPlayerComponent;
        public JumpPlayerComponent JumpPlayerComponent;

        public MovePlatformComponent MovePlatformComponent;
        public TeleportPlatformComponent TeleportPlatformComponent;

        public MoveBarriersComponent[] MoveBarriersComponent;
        public SpawnBarriersComponent SpawnBarriersComponent;

        public MoveBackgroundComponent[] MoveBackgroundComponent;

        public PlayerDeadAnimationComponent PlayerDeadAnimationComponent;
        public PlayerJumpAnimationComponent PlayerJumpAnimationComponent;

        public PopupGameOverAnimationComponent PopupGameOverAnimationComponent;
        public PopupPauseComponent PopupPauseComponent;
        
        public YesButtonGameOverComponent YesButtonGameOverComponent;
        public NoButtonGameOverComponent NoButtonGameOverComponent;
        public PauseButtonComponent PauseButtonComponent;

        public PointsComponent PointsComponent;
        public PointsTextComponent PointsTextComponent;

        public SpeedComponent SpeedComponent;

        public Transform[] Platforms;

        public GameObject[] Barriers;
        public GameObject[] Items;

        public float StartSpeed;
        public float Acceleration;

        public Animator PlayerAnimator;
    }
}