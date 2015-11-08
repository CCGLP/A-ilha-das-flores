using UnityEngine;
using System.Collections;

public class FinalCollide : MonoBehaviour {
	private ImageHandler image;
	// Use this for initialization
	void Start () {
		image = GameObject.Find ("Image").GetComponent<ImageHandler> ();
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		image.next ();
		Destroy (this.gameObject);

	}
}
