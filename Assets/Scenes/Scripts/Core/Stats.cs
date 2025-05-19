using UnityEngine;

/// <summary> Base stat system (Health/Mana) with min/max clamping. </summary>
public class Stats : MonoBehaviour
{
    [SerializeField] private float _currentValue;
    [SerializeField] private float _maxValue = 100f;
    [SerializeField] private float _minValue = 0f;

    public float CurrentValue
    {
        get => _currentValue;
        set => _currentValue = Mathf.Clamp(value, _minValue, _maxValue);
    }

    public float MaxValue => _maxValue;

    // Modify stat (positive = heal/gain, negative = damage/lose)
    public void Modify(float amount) => CurrentValue += amount;
}