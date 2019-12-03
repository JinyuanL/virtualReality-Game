using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayControl : MonoBehaviour {
    GameObject[] pics;
    GameObject pic;
    int puzzleName = 0;
    public int puzzleCount = 0;

	// Use this for initialization
	void Start () {
        transform.Find("GameOver").gameObject.SetActive(false);
        pics = GameObject.FindGameObjectsWithTag("Pic");
        foreach (GameObject p in pics){
            p.SetActive(false);
        }

    }
	
	// Update is called once per frame
	void Update () {
        //Collect all four puzzles
        if (puzzleCount == 4)
        {
            //Wait for a few seconds

            puzzleCount = 0;
            transform.Find("Fox").gameObject.SetActive(true);
            transform.Find("foxLight").gameObject.SetActive(true);
            transform.Find("GameOver").gameObject.SetActive(true);

            foreach (GameObject p in pics)
            {
                p.SetActive(false);
            }
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");
        if(other.gameObject.tag == "Puzzle")
        {
            Debug.Log("disappear");
            other.GetComponent<Renderer>().enabled = false;

            if (int.TryParse(other.gameObject.name, out puzzleName))
            {
                puzzleCount += 1;
                if (puzzleName >= 10 && puzzleName <= 13)
                {
                    pic = transform.Find("p1Table").gameObject;
                    pic.SetActive(true);
                }
                else if (puzzleName >= 20 && puzzleName <= 23)
                {
                    pic = transform.Find("p2Table").gameObject;
                    pic.SetActive(true);
                }
                else if (puzzleName >= 30 && puzzleName <= 33)
                {
                    pic = transform.Find("p3Table").gameObject;
                    pic.SetActive(true);
                }
                else if (puzzleName >= 40 && puzzleName <= 43)
                {
                    pic = transform.Find("p4Table").gameObject;
                    pic.SetActive(true);
                }
            }
            Debug.Log("actual name: "+ other.gameObject.name +" parse name: " + puzzleName);
        }
    }
}
