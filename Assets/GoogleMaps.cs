using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoogleMaps : MonoBehaviour {
	public Image img;
	// Use this for initialization
	public string url = "https://maps.googleapis.com/maps/api/staticmap?center=-15.77523577,-47.89970216&zoom=16&maptype=satellite&key=AIzaSyAkUJqVSbPHmvng9T5-2hK15oShQhL0dKY&size=480x620";
	IEnumerator  Start () {
		WWW www = new WWW(url);
		yield return www;
		img.sprite = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height), new Vector2(0, 0));
	}
	

}
