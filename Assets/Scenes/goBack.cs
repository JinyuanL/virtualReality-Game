using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class goBack : MonoBehaviour {
    public GameObject backMenu;
    int gloNum;
    int game1;
    void Start()
    {
        //backMenu.SetActive(true);
        gloNum = PlayerPrefs.GetInt("gloNum");
        game1 = PlayerPrefs.GetInt("game1");
        //Debug.Log(gloNum);

    }
    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //backMenu.SetActive(true);
            if(game1==0)
            {
                PlayerPrefs.SetInt("game1", 1);
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
