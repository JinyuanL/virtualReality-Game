using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuScript : MonoBehaviour {
    public GameObject menu1;
    private Vector3 oldPos;
    public GameObject hammer;
	// Use this for initialization
	void Start () {
        oldPos = new Vector3(-13, 1.69f, 5.19f);
        menu1.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		if(hammer.transform.position != oldPos)
        {
            menu1.SetActive(false);
        }
    }
}
