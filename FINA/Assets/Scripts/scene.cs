using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour {

	// pindah scene ke menu
	public void Menuscene() {
		SceneManager.LoadScene ("Menu");
		Debug.Log ("MenuPrompted");
	}

	// pindah scene ke gameplay
	public void Gameplayscene() {
		SceneManager.LoadScene ("Gameplay");
		Debug.Log ("GameplayPrompted");
	}

	// keluar dari game
	public void Gameoverscene () {
		SceneManager.LoadScene ("Gameover");
	Application.Quit ();

	}
}
