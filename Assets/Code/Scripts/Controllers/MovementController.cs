using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MovementController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private float speed;

    public float Velocity
    {
        get => rb.linearVelocity.magnitude;
    }

    public float Direction
    {
        get => rb.linearVelocity.x;
    }

    public void Move(float x, float z)
    {
        Vector3 move = new Vector3(x, 0, z) * speed;
        Vector3 y = new Vector3(0, rb.linearVelocity.y, 0);

        rb.linearVelocity = (move + y);
    }
}