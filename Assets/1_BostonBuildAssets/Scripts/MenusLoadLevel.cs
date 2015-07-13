using UnityEngine;
using System.Collections;

public class MenusLoadLevel : MonoBehaviour {

	private GameObject StartGame, ExitApp;

	public Sprite SpriteSwap;
	private SpriteRenderer spriteRenderer;

	void Start (){
				StartGame = GameObject.Find ("StartGame");
				ExitApp = GameObject.Find ("ExitApp");
				//StartCoroutine(Example());
			spriteRenderer = GetComponent<SpriteRenderer>();
		}


	IEnumerator CountDown(){
		yield return new WaitForSeconds (1);
	}
	void OnMouseDown() {
		if (gameObject.name=="StartGame"){
			spriteRenderer.sprite = SpriteSwap;
			StartCoroutine(CountDown());{
			Application.LoadLevel(1);
			}

}

			else if(gameObject.name=="ExitApp"){
			spriteRenderer.sprite = SpriteSwap;
			Application.Quit();
		}
} 
}
