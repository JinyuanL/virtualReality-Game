using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWritterEffect : MonoBehaviour {

    public float delay = 0.2f;
    public string fullText;
    private string currentText = "";
    //For dispay control button
    public static int isFinished = 0;
    
    // Use this for initialization
	void Start () {
        StartCoroutine(ShowText());
	}
	
    IEnumerator ShowText()
    {
        fullText = fullText.Replace("@", System.Environment.NewLine);
        var words = fullText.Split(' ');
        for(int i = 0; i < words.Length; i++)
        {
            currentText += words[i] + " ";
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
        isFinished = 1;
    }
}
