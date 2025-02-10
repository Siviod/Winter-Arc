using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    
[SerializeField] GameObject projectile;
void Awake()
{
    projectile.SetActive(false);
}
void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Player")
        {
            projectile.SetActive(true);
        }
    
    }
}