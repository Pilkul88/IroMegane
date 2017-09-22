using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitioner : MonoBehaviour {

	public enum TransitionAnimationType {
		Feed,
		AAA
	}

	public void transitionSceen(string loadedScene, TransitionAnimationType animType ) {
		SceneManager.LoadScene( loadedScene );
	}
	
}
