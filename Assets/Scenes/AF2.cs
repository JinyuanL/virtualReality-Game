using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AF2 : MonoBehaviour
{
    public GameObject text;

    float speed = 0.0f;
    bool start = false;
    bool trackSwitch = false;
    private Vector3 rightTracking, leftTracking;
    private Vector2 rightControl, leftControl;
    float terrainhgt = 0.0f;
    public GameObject gameoverUI;
    private bool iscrashed = false;
    //private AudioSource bomb;

    // Use this for initialization
    void Start()
    {
        //bomb = GetComponent<AudioSource>();

    }
    /*
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Target1" || other.tag == "Target2" || other.tag == "Target3" || other.tag == "Target4" || other.tag == "Target5")
        {
            iscrashed = true;
        }
    }
    */
    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
           // if (Input.GetKeyDown("space"))
        {

                text.SetActive(false);
                speed = 40.0f;
            start = true;

        }
        if (start == true)
        {
            //Here start flight
            leftControl = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
            rightControl = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);
            // acceleration:
            speed += leftControl.y;  // left controller axis moving front/back
                                     //transform.position += new Vector3(1, 1, 1) * Time.deltaTime * speed;
            transform.Translate(0, 0, speed * Time.deltaTime);
            if (speed == 0) speed = 0;
            else if (speed < 10)
            {
                speed = 10;
            }
            if (speed > 150)
            {
                speed = 150;
            }
            //Debug.Log(speed);

            // yaw, pitch, roll:
            /*if (OVRInput.GetDown(OVRInput.Button.One))  // Pressed "A" on right controller
            {
                trackSwitch = !trackSwitch;  // turn on position and rotation tracking of touch controllers
            }*/

            transform.Rotate(rightControl.y * 50 * Time.deltaTime, leftControl.x * 50 * Time.deltaTime, -rightControl.x * 50 * Time.deltaTime); // left/right movement flipped

        }


    }
}