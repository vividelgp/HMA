using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private PlayableCarrier _carrier;

    private void Update() => _slider.value = _carrier.Mana.CurrentValue / _carrier.Mana.MaxValue;
}