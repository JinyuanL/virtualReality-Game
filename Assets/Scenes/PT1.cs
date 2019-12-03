using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PT1 : MonoBehaviour
{
    public int gloNum = 0;
    public int game1= 0;
    public int game2 = 0;
    public int game3 = 0;
    // Use this for initialization
    void Start()
    {
        PlayerPrefs.SetInt("gloNum", gloNum);
        PlayerPrefs.SetInt("game1", game1);
        PlayerPrefs.SetInt("game2", game2);
        PlayerPrefs.SetInt("game3", game3);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {   
        if (other.gameObject.tag == "LittlePrince")
        {
            if (gloNum==0)
            {
                SceneManager.LoadScene("MainSceneStart");
            }
            else SceneManager.LoadScene("MainScene");
        }
    }
}
