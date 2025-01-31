using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    void Start()
    {
        

    }
    void Update()
    {
        /* Here we be gettin the x and z axis and put that shit with the keyboard cuz 
        unity alrdy knows that, gang. so we use strings as in "" quotes n fuck nut
        by multiplying our moves with time we aint bound toframes but we bound to time typeshit*/
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate (xValue, yValue, zValue);
    }
    
}
