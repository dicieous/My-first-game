using UnityEngine;

public class playercollision : MonoBehaviour
{
    public player movement; 
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<gamemanager>().Endgame(); 
        }
    }
}
 