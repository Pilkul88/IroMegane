using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenEffect : MonoBehaviour {


	/// <summary>
	/// フェードインの処理
	/// </summary>
	public IEnumerator FeedIn(float second) {
		GameObject screenEffectPanel; // = Instantiate
		//Image img = screenEffectPanel.GetComponent<Image>();

		yield return new WaitForSeconds(1.0f);
	}
}
