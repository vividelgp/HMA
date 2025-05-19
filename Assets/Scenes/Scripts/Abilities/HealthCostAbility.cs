using UnityEngine;

public class HealthCostAbility : Ability
{
    public override void Use(Carrier carrier)
    {
        base.Use(carrier); // Applies cooldown and cost
        Debug.Log("Blood Strike: Deals damage at the cost of health!");
        
    }
}
