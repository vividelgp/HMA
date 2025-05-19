using UnityEngine;

public class PlayableCarrier : Carrier
{
    [SerializeField] private Stats _mana;

    protected override void Start()
    {
        base.Start();
        Mana = _mana; 
    }

    public void UseAbility(int index)
    {
        if (index >= 0 && index < _abilities.Count)
            _abilities[index].Use(this);
    }
}
