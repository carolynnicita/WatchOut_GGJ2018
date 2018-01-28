using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simplemove : MonoBehaviour {
    public GameObject target;
	// Use this for initialization
	void Start () {
        if (!target)
        {
            target = GameObject.Find("Camera (eye)");
        }
        transform.LookAt(target.transform);
        transform.Rotate(Vector3.right * 180);
    }
	
	// Update is called once per frame
	void Update () {
       
        transform.Translate(new Vector3(0,0,-0.01f),Space.Self);
	}
}
