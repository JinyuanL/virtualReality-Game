using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class goBack3 : MonoBehaviour {
    int gloNum;
    int game3;
    // Use this for initialization
    void Start () {
        gloNum = PlayerPrefs.GetInt("gloNum");
        game3 = PlayerPrefs.GetInt("game3");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            // backMenu.SetActive(true);
            if (game3 == 0)
            {
                PlayerPrefs.SetInt("game3", 1);
                if (gloNum == 0)
                {
                    PlayerPrefs.SetInt("gloNum", gloNum + 1);
                    SceneManager.LoadScene("Home2");
                }
                else if (gloNum == 1)
                {
                    PlayerPrefs.SetInt("gloNum", gloNum + 1);
                    SceneManager.LoadScene("Home3");
                }
                else if (gloNum == 2)
                {
                    PlayerPrefs.SetInt("gloNum", gloNum + 1);
                    SceneManager.LoadScene("Home4");
                }
            }
            else
            {
                if (gloNum == 0)
                {
                    SceneManager.LoadScene("Home1");
                }
                else if (gloNum == 1)
                {
                    SceneManager.LoadScene("Home2");
                }
                else if (gloNum == 2)
                {
                    SceneManager.LoadScene("Home3");
                }
            }


        }

    }
}
