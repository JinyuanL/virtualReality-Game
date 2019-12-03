using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class timerScript : MonoBehaviour {
    Image timeBar;
    public float playTime = 20f;
    float timeLeft;
    float timepassed;
    public GameObject gameoverText;

	// Use this for initialization
	void Start () {
        gameoverText.SetActive(false);
        timepassed = 0f;
       // if (menuScript.isStarted)
      //  {
            timeBar = GetComponent<Image>();
            timeLeft = playTime;
            Time.timeScale = 1f;
       // }
        
    }
	
	// Update is called once per frame
	void Update () {
        timepassed += Time.deltaTime;
        if (timepassed > 18)  // automatically start the timer once 15 seconds have passed
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                timeBar.fillAmount = timeLeft / playTime;
            }
            else
            {
                gameoverText.SetActive(true);
                Time.timeScale = 0;

                if (OVRInput.GetDown(OVRInput.Button.One)) // press "A" to restart game
                {
                    SceneManager.LoadScene("forest1");
                }     

            }
        }
            
      //  }

    }
}
