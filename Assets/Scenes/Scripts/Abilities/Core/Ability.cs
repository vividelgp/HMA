using UnityEngine;

public enum AbilityCostType { Health, Mana }

public abstract class Ability : MonoBehaviour
{
    [Header("Base Settings")]
    [SerializeField] protected string _name;
    [SerializeField] protected Sprite _icon;
    [SerializeField] protected float _cooldown = 2f;
    [SerializeField] protected AbilityCostType _costType;
    [SerializeField] protected float _costAmount = 10f;


    private float _lastUsedTime = -Mathf.Infinity;

    public bool CanUse => Time.time > _lastUsedTime + _cooldown;

    public virtual void Use(Carrier carrier)
    {
        if (!CanUse) return;

        _lastUsedTime = Time.time;
        ApplyCost(carrier);
        Debug.Log($"Used ability: {_name}");
    }

    protected void ApplyCost(Carrier carrier)
    {
        if (_costType == AbilityCostType.Health)
            carrier.Health.Modify(-_costAmount);
        else
            carrier.Mana.Modify(-_costAmount);
    }
}