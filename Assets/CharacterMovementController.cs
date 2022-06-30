using UnityEngine;

public class CharacterMovementController : MonoBehaviour
{
    [SerializeField] private float speed;

    private void FixedUpdate()
    {
        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

        transform.position = new Vector3(transform.position.x + horizontal * speed, 0,
            transform.position.z + vertical * speed);
    }
}