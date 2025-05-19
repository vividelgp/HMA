using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    private Rigidbody _rb;
    private Vector2 _moveInput;

    private void Awake() => _rb = GetComponent<Rigidbody>();


    public void OnMove(InputAction.CallbackContext context)
    {
        _moveInput = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Vector3 moveDir = transform.right * _moveInput.x + transform.forward * _moveInput.y;
        _rb.linearVelocity = moveDir * _speed;
    }
}