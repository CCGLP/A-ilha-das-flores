using UnityEngine;
using System.Collections;

public class Suzuki_Controller : MonoBehaviour {
	private Rigidbody2D rb;
	public float speed;
	private bool isWalking;
	private Animator anim;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		isWalking = false;
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Mathf.Abs(rb.velocity.x) < 3 && Input.GetAxis("Horizontal") != 0) {

			rb.AddForce (Vector2.right * Input.GetAxis ("Horizontal") * speed);
			this.isWalking= true;
			anim.SetBool ("isWalking", isWalking);
		}

		if (rb.velocity.x == 0) {
			this.isWalking = false;
			anim.SetBool ("isWalking", isWalking);
		} else if (rb.velocity.x < -0.2) {
			this.transform.localScale = new Vector3 (-1, 1, 1);
		} else if (rb.velocity.x > 0.2) {
			this.transform.localScale = new Vector3(1,1,1);
		}
	}
}
