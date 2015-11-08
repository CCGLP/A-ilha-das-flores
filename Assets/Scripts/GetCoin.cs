using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GetCoin : MonoBehaviour {

	private Text scoreText;
	private ScoreHandler score;
	// Use this for initialization
	void Start () {

		scoreText = GameObject.Find ("Score").GetComponent<Text> ();
		score = this.GetComponentInParent<ScoreHandler> ();
	}
	
	void OnMouseOver(){
		print ("HHiii");
		if (Input.GetMouseButton(0)){
			print ("Hi");
			score.addScore(scoreText);
			Destroy(this.gameObject);

		}
	}
}
