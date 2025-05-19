using UnityEngine;

public class DamageArea : MonoBehaviour
{
    [SerializeField] private float _damage = 10f;

    private void OnTriggerStay(Collider other)
    {
        if (other.TryGetComponent(out Carrier carrier))
            carrier.Health.Modify(-_damage * Time.deltaTime);
    }
}