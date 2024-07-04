using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public IPlayerInput PlayerInput { get; set; }
    float moveSpeed = 10f;

    private void Awake() 
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.useGravity = false;
    }

    private void Update() 
    {
        float vertical = PlayerInput.Vertical;

        _rigidbody.AddForce(Vector3.forward * vertical * moveSpeed);
    }
}
