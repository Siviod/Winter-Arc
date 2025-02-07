using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem.Controls;

public class Jump : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce = 10f;
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // ✅ Get Rigidbody (3D)
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) // ✅ Jump only if on ground
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // ✅ Apply upward force
            isGrounded = false; // ✅ Prevent double jump
        }
    }

    void OnCollisionEnter(Collision collision) // ✅ Detect ground contact
    {
        isGrounded = true;
    }
}