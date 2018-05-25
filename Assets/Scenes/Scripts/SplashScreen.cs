using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SplashScreen : MonoBehaviour {

	public static int sceenNumber; 
	// Use this for initialization
	void Start () {

		if(sceenNumber == 0){
			StartCoroutine(ToSplashTwo()); 
		}

		if(sceenNumber == 1){
			StartCoroutine(ToMainMenu()); 
		}
	}

	IEnumerator ToSplashTwo() {
		yield return new WaitForSeconds(5);
		sceenNumber = 1; 
		SceneManager.LoadScene(1); 
	}

	IEnumerator ToMainMenu(){
		yield return new WaitForSeconds(5);

		sceenNumber = 2;
		SceneManager.LoadScene(2); 
	}
}
