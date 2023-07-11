using UnityEngine;
using UnityEngine.UI;

namespace Shop.SelectBackground.BackgroundButton
{
    public class SelectBackgroundScrollComponent : MonoBehaviour
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;
        private int _backgroundIndex;

        [SerializeField] private Button _button;

        public void Initialize(ShopModel shopModel, ShopScene shopScene, int backgroundIndex)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;
            _backgroundIndex = backgroundIndex;
            
            _button.onClick.AddListener(OnClicked);
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(OnClicked);
        }

        private void OnClicked()
        {
            _shopModel.SelectedBackground.Value = _backgroundIndex;
        }
    }
}