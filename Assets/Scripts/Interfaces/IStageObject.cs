using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IStageObject : MonoBehaviour {


	/// <summary>
	/// オブジェクトの色
	/// </summary>
	public enum ObjectColor {
		RED,
		BLUE,
		GREEN,
		BLACK
	}


	/// <summary>
	/// オブジェクトの属性
	/// </summary>
	public enum ObjectType {
		PLAYER,
		ENEMY,
		STAGE
	}


	/// <summary>
	/// Dynamicな変数
	/// </summary>
	public bool isRenderer; //カメラに写っているかどうか
	public bool isVisible;	//見えるかどうか

	//SpriteRendererを持っているかどうか
	public bool hasSpriteRenderer {
		get {
			bool hasSp = false;
			if( GetComponent<SpriteRenderer>() != null ) {
				hasSp = true;
			}
			return hasSp;
		}
	}


	/// <summary>
	/// Staticな変数
	/// </summary>
	public ObjectColor myColor;	//自身の色
	public ObjectType myObject; //自身の属性


	/// <summary>
	/// カメラに映り始めた時の処理
	/// </summary>
	public void OnBecameVisible() {
		if( Camera.current.name == "Main Camera" )
			isRenderer = true;
	}

	/// <summary>
	/// カメラから外れた時の処理
	/// </summary>
	public void OnBecameInvisible() {
		if( Camera.current.name == "Main Camera" )
			isRenderer = false;
	}


	/// <summary>
	/// Spriteの切り替え
	/// </summary>
	public void switchVisible() {
		if( !hasSpriteRenderer ) {
			return;
		}

		Sprite visibleSprite = getSprite( true );
		Sprite invisibleSprite = getSprite( false );

		if( isVisible ) {
			GetComponent<SpriteRenderer>().sprite = invisibleSprite;
			isVisible = false;
		}
		else {
			GetComponent<SpriteRenderer>().sprite = visibleSprite;
			isVisible = true;
		}
	}


	/// <summary>
	/// Spriteの取得(override前提)
	/// </summary>
	public Sprite getSprite( bool visible ) {
		return null;
	}


}
