using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class goBack2 : MonoBehaviour {
    int gloNum;
    int game2;
    //public GameObject backMenu;
    // Use this for initialization
    void Start () {
        gloNum = PlayerPrefs.GetInt("gloNum");
        game2 = PlayerPrefs.GetInt("game2");
        //backMenu.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            //backMenu.SetActive(true);
            //if (OVRInput.GetDown(OVRInput.Button.One))
            //{
                if (game2 == 0)
                {
                    PlayerPrefs.SetInt("game2", 1);
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
            //}
            /*
            else if (OVRInput.GetDown(OVRInput.Button.One))
            {
                backMenu.SetActive(false);
            }*/




        }

    }
}
