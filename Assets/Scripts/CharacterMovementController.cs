using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMovementController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float fallSpeed;
    [SerializeField] private float rotationSpeed;
    private bool _isFalling = false;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();

        if (!_isFalling)
        {
            _rigidbody.velocity = movementDirection * speed * Time.deltaTime;
        }


        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation =
                Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

        if (_rigidbody.position.y < -40)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _isFalling = true;
        _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, -fallSpeed, _rigidbody.velocity.z);
    }
}