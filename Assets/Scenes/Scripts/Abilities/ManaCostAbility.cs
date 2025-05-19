using UnityEngine;

public class ManaCostAbility : Ability
{
    public override void Use(Carrier carrier)
    {
        base.Use(carrier);
        Debug.Log("Fireball: Shoots a fireball using mana!");
        // Add logic (e.g., instantiate a fireball prefab)
    }
}