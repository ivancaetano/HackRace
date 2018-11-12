using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dificuldade : MonoBehaviour {
	public GameObject Facil;
	public GameObject Medio;
	public GameObject Dificil;
	public Sprite Marcado;
	public Sprite Desmarcado;
	public bool icMarcado;
	void Update()
	{
		if(icMarcado)
		{
			GetComponent<Image>().sprite =Marcado;
			GetComponent<RectTransform>().sizeDelta = new Vector2 (52, 42);
			transform.localPosition = new Vector3(163, transform.localPosition.y, transform.localPosition.z);
		}
		else
		{
			GetComponent<Image>().sprite =Desmarcado;
			GetComponent<RectTransform>().sizeDelta = new Vector2 (42, 42);
			transform.localPosition = new Vector3(159, transform.localPosition.y, transform.localPosition.z);
		}
	}
	public void Troca () {
		icMarcado=true;
		if(this.name=="Facil")
		{
			Medio.GetComponent<Dificuldade>().icMarcado=false;
			Dificil.GetComponent<Dificuldade>().icMarcado=false;
		}
		else if(this.name=="Medio")
		{
			Facil.GetComponent<Dificuldade>().icMarcado=false;
			Dificil.GetComponent<Dificuldade>().icMarcado=false;
		}
		else if(this.name=="Dificil")
		{
			Facil.GetComponent<Dificuldade>().icMarcado=false;
			Medio.GetComponent<Dificuldade>().icMarcado=false;
		}
	}
}
