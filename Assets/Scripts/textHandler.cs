using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class textHandler : MonoBehaviour {
	public int sceneNumber =0;
	public bool autoMatic= false;
	private string [] escena;
	public float timeBetween = 0f;
	private Text text;
	public int[] imagesHuecos;
	ImageHandler image;
	public string newLevel = "Level_02"; 

	// Use this for initialization
	void Start () {
		escena = Strings.getTextoEscena (sceneNumber);
		text = this.GetComponent<Text> ();
		image = GameObject.Find ("Image").GetComponent<ImageHandler> ();
		if (autoMatic) {
			StartCoroutine("nextMatic");
		}
	}
	
	// Update is called once per frame
	IEnumerator nextMatic(){
		int i;
		int j = 0;
		for (i=0; i<escena.Length; i++){

			text.text = escena[i];
			while (j<imagesHuecos.Length && imagesHuecos[j] == i){
				image.next();
				j++;
				yield return new WaitForSeconds(1);
			}
			image.fade();

			yield  return new WaitForSeconds(timeBetween) ;
		}
		Application.LoadLevel (newLevel);

	}
}
