using Unity.Collections;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other) 
    {
            Debug.Log("You've hit your wife " + hits +" many times");
            hits++;
    }

}
