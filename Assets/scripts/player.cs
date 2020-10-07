using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody rb;
    public float forewardforce = 2000f;
    public float sidemovement = 500f;
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forewardforce*Time.deltaTime);
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidemovement * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidemovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y<-2f)
        {
            FindObjectOfType<gamemanager>().Endgame();
        }
    } 
 
}
