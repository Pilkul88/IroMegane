using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StageSelectHandler : IMenu_Input {

	public enum StageName {
		DEFAULT,
		Title,
		Stage1

	}

	[SerializeField]
	private StageName selectedStage;


	SceneTransitioner st = new SceneTransitioner();


	void Start () {
		selectedStage = StageName.DEFAULT;
	}
	
	void Update () {
		if(horizontalAxisHandler != AxisVectol.ZERO ) {
			selectedStage = setNextSelectedStage();
			//Debug.Log( selectedStage );
		}
	}

	
	string gererateSceneName( StageName targetStage ) {
		string sceneName = "Title";
		sceneName = Enum.GetName( typeof( StageName ), targetStage );

		return sceneName;
	}

	//次候補に移動する
	private StageName setNextSelectedStage() {
		StageName nextStage = StageName.DEFAULT;

		switch( horizontalAxisHandler ) {
			case AxisVectol.RIGHT:
				int axisVectolLength = getEnumLength<StageName>();
				if( ( int )selectedStage < axisVectolLength ) {
					nextStage = ( StageName )Enum.ToObject( typeof( StageName ), ( int )selectedStage++ );
				}
				break;

			case AxisVectol.LEFT:
				if( ( int )selectedStage > 0 ) {
					nextStage = ( StageName )Enum.ToObject( typeof( StageName ), ( int )selectedStage-- );
				}
				break;
		}

		return nextStage;
	}
}
