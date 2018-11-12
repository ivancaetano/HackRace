using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Start : MonoBehaviour {
	public GameObject capa;
	
	
	// Update is called once per frame
	public void BtStart () {
		capa.SetActive(false);
	}
	public void BtReStart () {
		Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
	}
}
