using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    Vector3 teleportPosition;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey("right"))
        {
            Camera.main.transform.Rotate(new Vector3(0f, Time.time * 0.1f, 0f));
        }
        if (Input.GetKey("left"))
        {
            Camera.main.transform.Rotate(new Vector3(0f, -Time.time * 0.1f, 0f));
        }
        if (Input.GetKey("up"))
        {
            Camera.main.transform.Rotate(new Vector3(Time.time * -0.1f, 0f, 0f));
        }
        if (Input.GetKey("down"))
        {
            Camera.main.transform.Rotate(new Vector3(Time.time * 0.1f, 0f, 0f));
        }
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Spacebar");
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
            {
                Debug.Log("Contact");
                teleportPosition = hit.transform.position;
                Camera.main.transform.position = teleportPosition;
            }
        }
	}
}
