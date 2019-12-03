using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {
	
	Transform player;
	Rigidbody enemyRB;
	float radius=10f, stopDistance=3f, attackDistance=2f, rSpeed=5f, tSpeed=3f, aSpeed = 6f;
	bool attacked = false;
	public Text hpText;
	public AudioClip follow, attack;
	public AudioSource followSource, attackSource;
	
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").transform;
		enemyRB = GetComponent<Rigidbody>();
		followSource.clip = follow;
		attackSource.clip = attack;
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance(player.position, transform.position);
		float height = transform.position.y;
		transform.position -= new Vector3(0, height - 1.5f, 0);
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.position - transform.position), rSpeed * Time.deltaTime);
		
		if(distance <= radius && distance > stopDistance){
			if(!followSource.isPlaying){
				followSource.Play();
			}
			transform.position += transform.forward * tSpeed * Time.deltaTime;
			attacked = false;
		}

		else if(distance <= stopDistance){
			if(distance <= attackDistance){
				if(!attackSource.isPlaying){
					attackSource.Play();
				}
				attacked = true;
				float hp = int.Parse(hpText.text);
				if(hp > 0){
					hp--;
					hpText.text = hp.ToString();
				}
			}
			if(attacked == false){
				transform.position += transform.forward * aSpeed * Time.deltaTime;
			}
			else{
				transform.position -= transform.forward * aSpeed * Time.deltaTime;
			}
		}
		
		enemyRB.Sleep();
		/*else{
			//enemyRB.velocity = Vector3.zero;
			//enemyRB.angularVelocity = Vector3.zero;
			enemyRB.Sleep();
			//Debug.Log("!");
		}*/
	}
	
}
