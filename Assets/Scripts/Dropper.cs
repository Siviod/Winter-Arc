using UnityEngine;

public class Dropper : MonoBehaviour
{
    int DropTimerCube = 3;
    bool hasDropped = false;
    Rigidbody rb;
    MeshRenderer mr;
    void Start() 
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        
        mr = GetComponent<MeshRenderer>();
        mr.enabled = false;
    }
    
    void Update()
    {
        if (!hasDropped && Time.time > DropTimerCube)
        {
            Debug.Log("Gang droppin down");
            mr.enabled = true;
            rb.useGravity = true;
            hasDropped = true;
        }        
    }
}
