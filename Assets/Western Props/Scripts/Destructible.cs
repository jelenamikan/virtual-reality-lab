// --------------------------------------
// This script is totally optional. It is an example of how you can use the
// destructible versions of the objects as demonstrated in my tutorial.
// Watch the tutorial over at http://youtube.com/brackeys/.
// --------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour {

	public GameObject destroyedVersion;	// Reference to the shattered version of the object
    public GameObject candle1;
    public GameObject candle2;
    public AudioSource src;
    public AudioClip clip;

    void Start()
    {
        src = GetComponent<AudioSource>();
    }

	// If the player clicks on the object
	void OnMouseDown ()
	{
		// Spawn a shattered object
		Instantiate(destroyedVersion, transform.position, transform.rotation);
        src.PlayOneShot(clip, 0.8F);
        StartCoroutine(Wait());
        // Remove the current object
        Destroy(gameObject);
        candle1.GetComponent<Collider>().enabled = true;
        candle2.GetComponent<Collider>().enabled = true;
    }

    IEnumerator Wait()
    {
        //yield on a new YieldInstruction that waits for 1 second.
        yield return new WaitForSeconds(1);
    }

}
