using UnityEngine;

public class CharacterMovementAnimationController : MonoBehaviour
{
    private void FixedUpdate()
    {
        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

        GetComponent<Animator>().SetBool("isWalking", vertical != 0F || horizontal != 0F);
    }
}