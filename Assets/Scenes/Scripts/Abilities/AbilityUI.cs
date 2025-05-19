using UnityEngine;
using UnityEngine.UI;

public class AbilityUI : MonoBehaviour
{
    [SerializeField] private PlayableCarrier _player; 
    [SerializeField] private Button[] _abilityButtons;

    private void Start()
    {
        // Bind buttons to abilities (index 0, 1, 2)
        _abilityButtons[0].onClick.AddListener(() => _player.UseAbility(0));
        _abilityButtons[1].onClick.AddListener(() => _player.UseAbility(1));
        _abilityButtons[2].onClick.AddListener(() => _player.UseAbility(2));
    }
}
