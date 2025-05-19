using UnityEngine;

public class UnplayableCarrier : Carrier
{
    protected override void Start()
    {
        base.Start();
        _health.Modify(_health.MaxValue); // Start at full health
    }

    private void Update()
    {
        if (_health.CurrentValue <= 0)
            Destroy(gameObject); // Simple death
    }
}
