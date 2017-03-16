using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCube : MonoBehaviour
{
    public float speed;
    Vector3 localRotation;

    // Use this for initialization
    void Start ()
    {
        localRotation = this.transform.rotation.eulerAngles;

    }
	
	// Update is called once per frame
	void Update () {
        this.transform.localEulerAngles = new Vector3(Time.time * speed, Time.time * speed, localRotation.z);
	}
}
