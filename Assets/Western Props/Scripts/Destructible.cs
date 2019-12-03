using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Destructible : MonoBehaviour {

	public GameObject destroyedVersion; // Reference to the shattered version of the object
    public GameObject popObj;
    public AudioClip boxClip;
    public AudioClip bottleClip;
    public AudioSource musicSource;
    public AudioSource musicSourcebottle;

    void Start()
    {
        musicSource.clip = boxClip;
        musicSourcebottle.clip = bottleClip;
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "hammer")
        {
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            Destroy(gameObject);
            if (this.CompareTag("box"))
            {
                musicSource.Play();
            }
            else if (this.CompareTag("bottle"))
            {
                musicSourcebottle.Play();

            }
            Instantiate(popObj, new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z), Quaternion.Euler(transform.rotation.x - 90, transform.rotation.y, transform.rotation.z));
        }
    }

}
