using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStatus : MonoBehaviour {
	
	float hp, score;
	public Text hpText, scoreText;
	bool gamePaused, gameOver, gameWon, gameOverPlayed, winPlayed;
	public GameObject pointerP, pauseMenu, pointerG, gameOverMenu, pointerW, gameWonMenu;
	public AudioClip gameOverClip, winClip;
	public AudioSource gameOverSource, winSource;
    int gloNum;
    int game3;

    // Use this for initialization
    void Start () {
		hp = 20;
		score = 0;
		gamePaused = false;
		gameOver = false;
		gameWon = false;
		gameOverPlayed = false;
		winPlayed = false;
		gameOverSource.clip = gameOverClip;
		winSource.clip = winClip;
        gloNum = PlayerPrefs.GetInt("gloNum");
        game3 = PlayerPrefs.GetInt("game3");
    }
	
	// Update is called once per frame
	void Update () {
		hp = int.Parse(hpText.text);
		score = int.Parse(scoreText.text);
		//Debug.Log(hp);
		//Debug.Log(score);
		
		if(OVRInput.GetDown(OVRInput.Button.Start) && !gameOver && !gameWon){
			//Debug.Log("HERE");
			if(gamePaused){
				//Resume();
				pauseMenu.SetActive(false);
				Time.timeScale =1f;
				gamePaused = false;
			}
			else{
				//Pause();
				pauseMenu.SetActive(true);
				Time.timeScale =0f;
				gamePaused = true;
			}				
		}
		
		if(gamePaused){
			if(OVRInput.GetDown(OVRInput.Button.Two)){
				if(pointerP.transform.localPosition == new Vector3(-600f, 400f, 0f)){
					pauseMenu.SetActive(false);
					Time.timeScale =1f;
					gamePaused = false;
				}
				else if(pointerP.transform.localPosition == new Vector3(-600f, 0f, 0f)){
					//SceneManager.LoadScene("Scene_Name");
					Time.timeScale = 1f;
					SceneManager.LoadScene("Desert");
				}
				else{
					//pauseMenuUI.SetActive(false);
					Time.timeScale = 1f;

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
                    //SceneManager.LoadScene("StartScene");
                }
			}
			if(OVRInput.GetDown(OVRInput.Button.Four) /*Input.GetKeyDown(KeyCode.UpArrow)*/ && pointerP.transform.localPosition!= new Vector3(-600f, 400f, 0f)){
				//Debug.Log(pointerP.transform.localPosition);
				pointerP.transform.localPosition += new Vector3(0f, 400f, 0f);	
			}
			if(OVRInput.GetDown(OVRInput.Button.Three) /*Input.GetKeyDown(KeyCode.DownArrow)*/ && pointerP.transform.localPosition!= new Vector3(-600f, -400f, 0f)){
				pointerP.transform.localPosition -= new Vector3(0f, 400f, 0f);
			}
		}
		
		
		if(hp == 0){
			gameOver = true;
		}	
		if(gameOver){
			if(!gameOverSource.isPlaying && !gameOverPlayed){
				gameOverSource.Play();
			}
			gameOverPlayed = true;
			//Debug.Log("HERE");
			Time.timeScale =0f;
			gameOverMenu.SetActive(true);
			//GetComponent<AudioSource> ().Play ();
			//Debug.Log("Sound1!");
			//crash.PlayOneShot(crashClip, 0.5f);
			//jet.Stop();
			//Debug.Log("Sound2!");
			if(OVRInput.GetDown(OVRInput.Button.Two)){
				if(pointerG.transform.localPosition == new Vector3(-600f, 400f, 0f)){
					//pauseMenuUI.SetActive(false);
					Time.timeScale = 1f;
					SceneManager.LoadScene("Desert");
				}
				else if(pointerG.transform.localPosition == new Vector3(-600f, 0f, 0f)){
					//SceneManager.LoadScene("Scene_Name");
					Time.timeScale = 1f;
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
				else{
					#if UNITY_EDITOR
						UnityEditor.EditorApplication.isPlaying = false;
					#else 
						Application.Quit();
					#endif
				}
			}
			if(OVRInput.GetDown(OVRInput.Button.Four) /*Input.GetKeyDown(KeyCode.UpArrow)*/ && pointerG.transform.localPosition!= new Vector3(-600f, 400f, 0f)){
				//Debug.Log(pointerG.transform.localPosition);
				pointerG.transform.localPosition += new Vector3(0f, 400f, 0f);	
			}
			if(OVRInput.GetDown(OVRInput.Button.Three) /*Input.GetKeyDown(KeyCode.DownArrow)*/ && pointerG.transform.localPosition!= new Vector3(-600f, -400f, 0f)){
				pointerG.transform.localPosition -= new Vector3(0f, 400f, 0f);
			}
		}
		
		if(score == 6 && hp > 0){
			gameWon = true;
		}
		if(gameWon){
			if(!winSource.isPlaying && !winPlayed){
				winSource.Play();
			}
			winPlayed = true;
			//Debug.Log("HERE");
			Time.timeScale =0f;
			gameWonMenu.SetActive(true);
			//GetComponent<AudioSource> ().Play ();
			//Debug.Log("Sound1!");
			//crash.PlayOneShot(crashClip, 0.5f);
			//jet.Stop();
			//Debug.Log("Sound2!");
			if(OVRInput.GetDown(OVRInput.Button.Two)){
				if(pointerW.transform.localPosition == new Vector3(-600f, 400f, 0f)){
					//pauseMenuUI.SetActive(false);
					Time.timeScale = 1f;
					SceneManager.LoadScene("Desert");
				}
				else if(pointerW.transform.localPosition == new Vector3(-600f, 0f, 0f)){
					//SceneManager.LoadScene("Scene_Name");
					Time.timeScale = 1f;

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
                    //SceneManager.LoadScene("Flight");
                }		
				else{
					#if UNITY_EDITOR
						UnityEditor.EditorApplication.isPlaying = false;
					#else 
						Application.Quit();
					#endif
				}
			}
			if(OVRInput.GetDown(OVRInput.Button.Four) /*Input.GetKeyDown(KeyCode.UpArrow)*/ && pointerW.transform.localPosition!= new Vector3(-600f, 400f, 0f)){
				//Debug.Log(pointerG.transform.localPosition);
				pointerW.transform.localPosition += new Vector3(0f, 400f, 0f);	
			}
			if(OVRInput.GetDown(OVRInput.Button.Three) /*Input.GetKeyDown(KeyCode.DownArrow)*/ && pointerW.transform.localPosition!= new Vector3(-600f, -400f, 0f)){
				pointerW.transform.localPosition -= new Vector3(0f, 400f, 0f);
			}
		}

	}
}
