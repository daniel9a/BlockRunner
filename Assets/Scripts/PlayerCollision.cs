using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement; // reference to PlayerMovement script

    // This function runs when we hit another object
    // We get information about the collision and call it "collisionInfo"
    void OnCollisionEnter (Collision collisionInfo)
    {
        // We check if the object we collided with has a tag named "Obstacle"
        if (collisionInfo.collider.tag == "Obstacle")
        { 
            // Diable player movements
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
