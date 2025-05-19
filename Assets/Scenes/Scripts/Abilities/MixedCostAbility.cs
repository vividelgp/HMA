using UnityEngine;

public class MixedCostAbility : Ability
{
    public override void Use(Carrier carrier)
    {
        base.Use(carrier);
        carrier.Health.Modify(5f); 
        Debug.Log("Life Drain: Drains mana but heals slightly!");
    }
}