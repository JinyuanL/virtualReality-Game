using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class goBack : MonoBehaviour {
    //public GameObject backMenu;
    int gloNum;
    void Start()
    {
        //backMenu.SetActive(true);
        gloNum = PlayerPrefs.GetInt("gloNum");
        Debug.Log(gloNum);

    }
    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "player")
        {
            // backMenu.SetActive(true);
            
            if (gloNum==0)
            {
                PlayerPrefs.SetInt("gloNum", gloNum+1);
                SceneManager.LoadScene("Home2");
            }
            else if (gloNum == 1)
            {
                PlayerPrefs.SetInt("gloNum", gloNum+1);
                SceneManager.LoadScene("Home3");
            }
            else if(gloNum == 2)
            {
                PlayerPrefs.SetInt("gloNum", gloNum + 1);
                SceneManager.LoadScene("Home4");
            }
            Debug.Log("back to main planet..");
        }

    }
}
