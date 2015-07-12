using UnityEngine;
using System.Collections;

public class megaOn : MonoBehaviour {



public GameObject child;
	
	// Update is called once per frame
	void Update () {

		if(GameManager.megaCounter >= GUIMegaScript.buildingsTillMega){
			child.gameObject.SetActive(true);
		}
	//	else{
	//		gameObject.SetActive(false);
	//	}
	
	}
}





