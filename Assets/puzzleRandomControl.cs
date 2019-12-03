using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puzzleRandomControl : MonoBehaviour {

    public Button Continue;
    // Use this for initialization
    void Start () {
        //Random Set 4 puzzle pieces avaialbe during the game
        GameObject[] puzzles = GameObject.FindGameObjectsWithTag("Puzzle");
        string p1  = Random.Range(10, 14).ToString();
        string p2 = Random.Range(20, 24).ToString();
        string p3 = Random.Range(30, 34).ToString();
        string p4 = Random.Range(40, 44).ToString();
        foreach (GameObject p  in puzzles)
        {
            if ((string.Compare(p.name, p1) != 0) && (string.Compare(p.name, p2) != 0) && (string.Compare(p.name, p3) != 0) && (string.Compare(p.name, p4) != 0))
            {
                p.SetActive(false);
            }
        }

        GameObject.Find("Fox").SetActive(false);
        GameObject.Find("foxLight").SetActive(false);
        Continue.gameObject.SetActive(false);

        /**
            Debug.Log(p1);
            Debug.Log(p2);
            Debug.Log(p3);
            Debug.Log(p4);
        **/
    }
	
	// Update is called once per frame
	void Update () {
		if(TypeWritterEffect.isFinished == 1)
        {
            Continue.gameObject.SetActive(true);
            //Press A to continue
            if (OVRInput.GetDown(OVRInput.Button.One))
            {
                GameObject.Find("Introduction").SetActive(false);
                TypeWritterEffect.isFinished = 0;
            }
            
        }
	}
}
