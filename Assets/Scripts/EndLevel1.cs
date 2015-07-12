using UnityEngine;
using System.Collections;

public class EndLevel1 : MonoBehaviour {
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player" && GameManager.playerScore >= 200)	
		{
			Application.LoadLevel(2);	
			return;	
		}

		if(other.tag == "Player" && GameManager.playerScore < 200)
		{
			Application.LoadLevel(3);	
			return;	
		}

	}
}
