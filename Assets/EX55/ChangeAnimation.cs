using UnityEngine;
using UnityEngine.InputSystem;

public class ChangeAnimation : MonoBehaviour
{
    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.isPressed)
        {
            animator.SetBool("IsRunning", true);

        }
        else if (Keyboard.current.spaceKey.wasReleasedThisFrame)
        {
            animator.SetBool("IsRunning", false);
        }

    }
}
