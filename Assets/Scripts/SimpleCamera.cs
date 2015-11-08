using UnityEngine;
using System.Collections;

public class SimpleCamera : MonoBehaviour {
	public GameObject target;
	private float xTargetStart;
	private float sumX;

	// Use this for initialization
	void Start () {
		xTargetStart = target.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		sumX = target.transform.position.x - xTargetStart;
		this.transform.position = this.transform.position + Vector3.right * sumX;
		xTargetStart = target.transform.position.x;
	}
}
