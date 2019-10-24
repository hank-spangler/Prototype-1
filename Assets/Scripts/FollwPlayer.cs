 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollwPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 10, -12);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // offset the camera behind the player by adcding to the player's position
        transform.position = player.transform.position + offset;
    }
}
