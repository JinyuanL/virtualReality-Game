using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PT2 : MonoBehaviour {
    int gloNum;
    // Use this for initialization
    void Start () {
        gloNum = PlayerPrefs.GetInt("gloNum");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LittlePrince")
        {
            if (gloNum == 0)
            {
                SceneManager.LoadScene("MainSceneStart");
            }
            else SceneManager.LoadScene("MainScene");
        }
    }
}
