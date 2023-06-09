using UnityEngine;
using UnityEngine.UI;

namespace Shop.SelectCharacter.BuyButton
{
    public class ShowBuyButtonComponent : ShopComponent
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;

        [SerializeField] private Button _buttonBuy;
        [SerializeField] private Button _buttonSelect;

        public override void Initialize(ShopModel shopModel, ShopScene shopScene)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;

            UpdateVisible();

            _shopModel.SelectedSkin.Changed += OnChangedSelectedSkin;
            _shopModel.BoughtSkins.ItemAdded += OnItemAdded;
        }

        private void OnDestroy()
        {
            _shopModel.SelectedSkin.Changed -= OnChangedSelectedSkin;
            _shopModel.BoughtSkins.ItemAdded -= OnItemAdded;
        }

        private void OnItemAdded(int obj)
        {
            UpdateVisible();
        }

        private void OnChangedSelectedSkin()
        {
            UpdateVisible();
        }

        private void UpdateVisible()
        {
            var currentSkin = _shopModel.SelectedSkin.Value;

            if (_shopModel.BoughtSkins.Contains(currentSkin))
            {
                _buttonBuy.gameObject.SetActive(false);
                _buttonSelect.gameObject.SetActive(true);
            }
            else
            {
                _buttonBuy.gameObject.SetActive(true);
                _buttonSelect.gameObject.SetActive(false);
            }
        }
    }
}