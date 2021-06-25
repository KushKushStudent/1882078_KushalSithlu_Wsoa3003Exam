using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offeset;
    public float smoothing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Follow();    
    }
    void Follow() 
    {
        Vector3 playerPos = player.position + offeset;
        Vector3 smoothPos = Vector3.Lerp(player.position, playerPos, smoothing * Time.fixedDeltaTime);
        transform.position = playerPos;
    }
}
