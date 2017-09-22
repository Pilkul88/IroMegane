using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleHandler : IMenu_Input {

	SceneTransitioner st;

	void Start () {
		st = new SceneTransitioner();
	}
	
	void Update () {

		if( Input.anyKeyDown ) {
			st.transitionSceen( "StageSelect", SceneTransitioner.TransitionAnimationType.AAA );
		}

	}
}
