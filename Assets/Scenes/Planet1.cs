﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Planet1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LP")
        {

            SceneManager.LoadScene("forest1");

        }
    }
}
