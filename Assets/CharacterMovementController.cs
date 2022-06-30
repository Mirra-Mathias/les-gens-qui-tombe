using UnityEngine;

public class CharacterMovementController : MonoBehaviour
{
    [SerializeField] private float speed;

    private void FixedUpdate()
    {
        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

        //transform.position += Vector3.up * (vertical * speed);
        transform.position = new Vector3(transform.position.x + 1 * (horizontal * speed), 0, transform.position.z + 1 *
            (vertical * speed));
    }
}