using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour {
	public Texture ttt;
	// Use this for initialization
	void Start () {
		GetComponent<MeshRenderer> ().material.mainTexture = ttt;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
