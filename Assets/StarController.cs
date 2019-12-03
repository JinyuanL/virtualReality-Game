using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarController : MonoBehaviour {
	
	public Text scoreText;
	public AudioClip mario;
	public AudioSource starSource;
	public GameObject star;
	bool starCollected;
	
	// Use this for initialization
	void Start () {
		starSource.clip = mario;
		starCollected = false;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log("update");
	}
	
	void OnTriggerStay(Collider other){
		//Debug.Log("trigger");
		if(other.CompareTag("Player") && !starCollected){	
			if(OVRInput.GetDown(OVRInput.Button.One)){
				if(!starSource.isPlaying){
					starSource.Play();
				}
				float score = int.Parse(scoreText.text); 
				score++;
				scoreText.text = score.ToString();
				//Destroy(gameObject);
				star.SetActive(false);
				starCollected = true;
			}	
		}
	}
}
