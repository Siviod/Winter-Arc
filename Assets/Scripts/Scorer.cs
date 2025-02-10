using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;

public class Scorer : MonoBehaviour
{
    private int hits = 0;
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.GetComponent<ObjectHit>() != null && other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You've hit your wife " + hits + " times");
        }
        
    }

}
