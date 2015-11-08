using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ImageHandler : MonoBehaviour {
	private Image im;
	public Sprite[] sprites;
	private int contador = 0;

	private RectTransform rect;
	// Use this for initialization
	void Awake () {
		im = this.GetComponent<Image> ();
		rect = this.GetComponent<RectTransform> ();
	}
	
	public void next(){
		im.sprite = this.sprites [contador];
		contador ++;
		im.color = new Color32 (255, 255, 255, 255);
		rect.sizeDelta = new Vector2(Camera.main.pixelWidth, Camera.main.pixelHeight);



	}

	public void fade (){
		im.color = new Color32 (255, 255, 255, 0);

	}
}
