using UnityEngine;
using System.Collections.Generic;

public class Carrier : MonoBehaviour
{
    [SerializeField] protected Stats _health;
    [SerializeField] protected List<Ability> _abilities = new();

    public Stats Health => _health;
    public Stats Mana { get; protected set; } // Only for playable carriers

    protected virtual void Start()
    {
        if (_health == null)
            Debug.LogError("Health system not assigned!");
    }
}
