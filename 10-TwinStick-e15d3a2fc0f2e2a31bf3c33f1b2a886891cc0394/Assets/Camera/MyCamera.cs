using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour {

    public Transform player;
    public Vector3 offset;

	// Update is called once per frame
	void Update ()
    {
        // Camera follows the player with specified offset, except if he falls
        if(player.position.y >= -5)
        {
            transform.position = new Vector3(player.position.x + offset.x,
            player.position.y + offset.y, offset.z);
        }
    }
}
