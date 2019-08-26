using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestoryer : MonoBehaviour {

    private GameObject maincamera;

    // Use this for initialization
    void Start () {
        maincamera = GameObject.Find("Main Camera");
    }
	
	// Update is called once per frame
	void Update () {
        if (maincamera.transform.position.z > this.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
