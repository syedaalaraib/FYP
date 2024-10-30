
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Hello World");
        // rb.AddForce(0, 200, 500);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
         rb.AddForce(0, 0, forwardForce*Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        else if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime);
        }
        else if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, sidewaysForce * Time.deltaTime);
        }

        
    }
}
