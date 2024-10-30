
using UnityEngine;

public class collision : MonoBehaviour
{
    public playermovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "collision")
        {
            Debug.Log("We hit an obstacle");
            movement.enabled = false;
            
        }
    }
}
