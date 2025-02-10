using UnityEngine;

public class Bullet_move : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float bulletSpeed;
    Vector3 playerPosition;
    void Update()
    {
        playerPosition = player.transform.position;
        movetoPlayer();
        DestroyWhenReached();
    }
    void DestroyWhenReached()
    {
        if(transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
    void movetoPlayer()
        {
            transform.position = Vector3.MoveTowards(transform.position, playerPosition,Time.deltaTime * bulletSpeed); 
            // my position move towards (where I am now, towards player, speed)
        }
}
