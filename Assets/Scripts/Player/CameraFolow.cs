using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolow : MonoBehaviour {

    public float yOffset = 0;
    public float zOffset = 0;

    GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");

        if (yOffset == 0)
            yOffset = 7;
        if (zOffset == 0)
            zOffset = 5;
	}
	
	// Update is called once per frame
	void Update () {
        Camera.main.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + yOffset,player.transform.position.z - zOffset);
	}
}
