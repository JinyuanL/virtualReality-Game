using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ownPlayerController : MonoBehaviour {

	//Rigidbody playerRB;
	Vector2 leftStick, rightStick;
	float tSpeed = 4f, rSpeed = 100f;

	// Use this for initialization
	void Start () {
		//playerRB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		//playerRB.Sleep();
		//float height = transform.position.y;
		//transform.position -= new Vector3(0, height - 1.5f, 0);
		leftStick = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
		rightStick = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);
		//Debug.Log(leftStick);
		//transform.position += transform.forward * leftStick.y * tSpeed * Time.deltaTime;
		transform.Translate(leftStick.x * tSpeed * Time.deltaTime, 0 ,leftStick.y * tSpeed * Time.deltaTime);
		//transform.position += transform.forward * leftStick.y * tSpeed * Time.deltaTime;
		transform.Rotate(0, rightStick.x * rSpeed *Time.deltaTime, 0);
		//playerRB.Sleep();
	}
	
	
}
