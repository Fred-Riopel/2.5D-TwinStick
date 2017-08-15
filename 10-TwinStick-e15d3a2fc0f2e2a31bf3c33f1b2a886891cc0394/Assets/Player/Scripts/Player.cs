using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject startPointPole, checkPointPole;

    private GameObject player;
    private Vector3 startPoint, checkPoint;
    private bool isCheckPointReached = false;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        startPoint = new Vector3(startPointPole.transform.position.x, 0, 0);
        checkPoint = new Vector3(checkPointPole.transform.position.x, 0, 0);
    }

    // Update is called once per frame
    void Update ()
    {
        if(player.transform.position.x >= checkPointPole.transform.position.x)
        {
            isCheckPointReached = true;
        }

		if(player.transform.position.y < -50)
        {
            PlayerFellInHole();
        }
	}

    private void PlayerFellInHole()
    {
        if (isCheckPointReached)
        {
            player.transform.position = checkPoint;
        }
        else
        {
            player.transform.position = startPoint;
        }
    }
}
