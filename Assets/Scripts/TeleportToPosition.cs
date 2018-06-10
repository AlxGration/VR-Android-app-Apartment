using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToPosition : MonoBehaviour {

    public GameObject[] soundObjects;

	public void MovePlayer()
    {
        Player.SetPosition(transform.position);
        if (gameObject.GetComponent<Collider>().name == "Point_8")
        {
            soundObjects[0].GetComponent<AudioSource>().Stop();
            gameObject.GetComponent<AudioSource>().Play();
        }
        if (gameObject.GetComponent<Collider>().name == "Point_4")
        {
            soundObjects[1].GetComponent<AudioSource>().Stop();
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
