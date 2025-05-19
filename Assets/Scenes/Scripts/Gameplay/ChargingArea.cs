using UnityEngine;

public class ChargingArea : MonoBehaviour
{
    [SerializeField] private float _restoreRate = 5f;

    private void OnTriggerStay(Collider other)
    {
        if (other.TryGetComponent(out PlayableCarrier player))
            player.Mana.Modify(_restoreRate * Time.deltaTime);
    }
}