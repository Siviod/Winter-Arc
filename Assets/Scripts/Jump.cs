using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem.Controls;

public class Jump : MonoBehaviour
{
    private Rigidbody rb;
    private float jumpForce = 10f;
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false; 
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}