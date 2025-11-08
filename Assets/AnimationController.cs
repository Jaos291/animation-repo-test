using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Attack();
        }
        else
        {
            ReturnToIdle();
        }

        if (Input.GetKey(KeyCode.D))
        {
            Running();
        }
    }

    public void Attack()
    {
        animator.SetBool("IsAttacking", true);
    }

    public void Running()
    {
        animator.SetBool("IsRunning", true);
    }

    public void ReturnToIdle()
    {
        animator.SetBool("IsAttacking", false);
        animator.SetBool("IsRunning", false);
    }
}
