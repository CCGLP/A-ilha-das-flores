using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreHandler : MonoBehaviour {

	private int score = 0;
	
	public void addScore(Text text) {
		score++;
		text.text = "Score: " + score;


	}
}
