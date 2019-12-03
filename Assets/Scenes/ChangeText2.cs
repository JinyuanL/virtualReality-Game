using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeText2 : MonoBehaviour {
    private int num;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    // Use this for initialization
    void Start()
    {
        num = 0;
        text2.SetActive(false);
        text3.SetActive(false);
        text4.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
           // if (Input.GetKeyDown("space"))
        {
            if (num == 0)
            {
                text1.SetActive(false);
                text2.SetActive(true);
                num = num + 1;
            }
            else if (num == 1)
            {
                text2.SetActive(false);
                text3.SetActive(true);
                num = num + 1;
            }
            else if (num == 2)
            {
                text3.SetActive(false);
                text4.SetActive(true);
                num = num + 1;
            }
            else{
                #if UNITY_EDITOR
                                UnityEditor.EditorApplication.isPlaying = false;
                #else
                    Application.Quit();
                #endif
            }
        }


    }
}
