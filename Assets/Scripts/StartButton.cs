using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

	// Use this for initialization
	void OnMouseOver(){
		if (Input.GetMouseButton(0)){
			Application.LoadLevel("Level_01");
		}
	}
}
