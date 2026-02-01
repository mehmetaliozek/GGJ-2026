using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    public void Walk(float velocity)
    {
        animator.SetFloat("Velocity", Mathf.Abs(velocity));
    }

    public void Threat()
    {
        animator.SetTrigger("Threat");
    }

    public void Kill()
    {
        animator.SetTrigger("Kill");
    }
}