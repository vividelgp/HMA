using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Carrier _carrier;

    private void Update() => _slider.value = _carrier.Health.CurrentValue / _carrier.Health.MaxValue;
}