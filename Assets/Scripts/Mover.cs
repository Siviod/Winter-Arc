using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float rotateSpeed = 100f;
    
    void Start()
    {
        
    }
    void Update()
    {
        /* Here we be gettin the x and z axis and put that shit with the keyboard cuz 
        unity alrdy knows that, gang. so we use strings as in "" quotes n fuck nut
        by multiplying our moves with time we aint bound toframes but we bound to time typeshit*/
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        
        float yRotate = 0f;

        if (Input.GetMouseButton(0)) //sol click
        {
            yRotate = -rotateSpeed;
        }
        else if (Input.GetMouseButton(1)) //sağ click
        {
            yRotate = rotateSpeed;
        }

        transform.Translate (xValue, 0f, zValue);
        transform.Rotate (0f, yRotate * Time.deltaTime, 0);
    }
    
}
