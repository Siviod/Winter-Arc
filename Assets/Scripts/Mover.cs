using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float rotateSpeed = 100f;
    void Start()
    {
        PrintInstruction();
        
    }
    void Update()
    {
        MovePlayer();
        RotatePlayer();
        
    }
     void PrintInstruction()
    {
        Debug.Log("Go outside and drink beer!");
        Debug.Log("Go outside and drink beer!");
        Debug.Log("Go outside and drink beer!");
    }
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate (xValue, 0f, zValue);

    }
    void RotatePlayer()
    {
        float yRotate = 0f;

        if (Input.GetMouseButton(0)) //sol click
        {
            yRotate = -rotateSpeed;
        }
        else if (Input.GetMouseButton(1)) //sağ click
        {
            yRotate = rotateSpeed;
        }
        
        transform.Rotate (0f, yRotate * Time.deltaTime, 0);
    }
    
}
