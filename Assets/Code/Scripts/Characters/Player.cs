using UnityEngine;

public class Player : MonoBehaviour
{
    private MovementController movementController;
    private AnimationController animationController;

    private void Start()
    {
        movementController = GetComponent<MovementController>();
        animationController = GetComponent<AnimationController>();
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        movementController.Move(x, z);
        animationController.Walk(movementController.Velocity, movementController.Direction);
    }
}
