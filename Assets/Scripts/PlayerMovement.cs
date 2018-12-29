using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Reference to rigidbody component
    public Rigidbody rb;

    public float fowardForce = 8000f;
    public float sidewaysForce = 120f;
    // Start is called before the first frame update
    // Dont need start
    /*
    void Start()
    {

    }
    */
    // Update is called once per frame
    // FixedUpdate for physics
    void FixedUpdate()
    {
        // Add forward force
        rb.AddForce(0, 0, fowardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } else if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
