using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CarRotate : MonoBehaviour {
	public DateTime dhTeste;
	public float posicao;
	// Use this for initialization
	void Start () {
		this.dhTeste=DateTime.Now.AddSeconds(4);
		posicao=transform.localPosition.x+transform.localPosition.y+transform.localPosition.z;
	}
	
	// Update is called once per frame
	void Update () {
		if(dhTeste<DateTime.Now)
		{
			if(Mathf.Abs(posicao-(transform.localPosition.x+transform.localPosition.y+transform.localPosition.z))<1&&GameObject.Find("Cars").GetComponent<timer>().time>0)
			{
				transform.Rotate(Vector3.up * Time.deltaTime*3600, Space.World);
			}
			posicao=transform.localPosition.x+transform.localPosition.y+transform.localPosition.z;
			this.dhTeste=DateTime.Now.AddSeconds(4);
		}
	}
}
