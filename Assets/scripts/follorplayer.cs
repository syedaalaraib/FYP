 using UnityEngine;

public class follorplayer : MonoBehaviour
{ 
    public Transform player;
    public Vector3 offset;


    // Update is called once per frame
    void Update()
    {
        // Debug.Log(player.position);
        transform.position = player.position + offset;


    }
}
