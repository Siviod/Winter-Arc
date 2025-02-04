using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision other) 
    {
        Debug.Log("hit the bar n get sum beer");
    }

}
