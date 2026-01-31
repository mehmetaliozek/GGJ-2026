using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    public void Walk(float velocity, float direction)
    {
        animator.SetFloat("Velocity", Mathf.Abs(velocity));

        if (direction < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (direction > 1)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}