using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class IMenu_Input : MonoBehaviour {

	private KeyCode[] useKey;

	public void setUseKey( KeyCode[] setkey ) {
		useKey = null;
		useKey = setkey;
		setkey = null;
	}

	public enum AxisVectol{
		ZERO,
		UP,
		DOWN,
		RIGHT,
		LEFT
	}

	//平行方向にスティックが倒れているか
	public  AxisVectol horizontalAxisHandler {
		get {
			AxisVectol av = AxisVectol.ZERO;
			int fallValue = ( int )Input.GetAxis( "Horizontal" );
			//Debug.Log( Input.GetAxis( "Horizontal" ) +","+ fallValue);
			switch( fallValue ) {
				case 1:
					av = AxisVectol.RIGHT;
					break;
				case -1:
					av = AxisVectol.LEFT;
					break;
				default:
					av = AxisVectol.ZERO;
					break;
			}
			return av;
		}
	}

	//垂直方向にスティックが倒れているか
	public AxisVectol pressedVerticalAxisHandler {
		get {
			AxisVectol av = AxisVectol.ZERO;
			int fallValue = ( int )Input.GetAxis( "Vertical" );
			switch( fallValue ) {
				case 1:
					av = AxisVectol.UP;
					break;
				case -1:
					av = AxisVectol.DOWN;
					break;
				default:
					av = AxisVectol.ZERO;
					break;
			}
			return av;
		}
	}

	//useKey[]に登録されているkeyが押されている場合、キーコードを返す
	public KeyCode getKeyCode() {
		KeyCode targetKey = KeyCode.A;

		for( int i = 0; i < useKey.Length; i++ ) {
			if( Input.GetKeyDown( useKey[i] ) ) {
				targetKey = useKey[i];
			}
		}

		return targetKey;
	}


	/// <summary>
	/// 指定された列挙型の値の数返します
	/// </summary>
	public int getEnumLength<T>() {
		return Enum.GetValues( typeof( T ) ).Length;
	}

	//
	public void keyExecute( KeyCode targetKey ) {
		switch( targetKey ) {
			case KeyCode.Joystick1Button0:
				JoystickButton0();
				break;
			case KeyCode.Joystick1Button1:
				JoystickButton1();
				break;
			case KeyCode.Joystick1Button2:
				JoystickButton2();
				break;
			case KeyCode.Joystick1Button3:
				JoystickButton3();
				break;
			case KeyCode.Joystick1Button4:
				JoystickButton4();
				break;
			case KeyCode.Joystick1Button5:
				JoystickButton5();
				break;
			case KeyCode.Joystick1Button6:
				JoystickButton0();
				break;
			case KeyCode.Joystick1Button7:
				JoystickButton0();
				break;
			case KeyCode.Joystick1Button8:
				JoystickButton0();
				break;
			case KeyCode.Joystick1Button9:
				JoystickButton0();
				break;
			case KeyCode.Joystick1Button10:
				JoystickButton0();
				break;
			case KeyCode.Joystick1Button11:
				JoystickButton0();
				break;
			case KeyCode.Joystick1Button12:
				JoystickButton0();
				break;
			case KeyCode.Joystick1Button13:
				JoystickButton0();
				break;
			case KeyCode.Joystick1Button14:
				JoystickButton0();
				break;
			case KeyCode.Joystick1Button15:
				JoystickButton0();
				break;
			case KeyCode.Joystick1Button16:
				JoystickButton0();
				break;
			case KeyCode.Joystick1Button17:
				JoystickButton0();
				break;
			case KeyCode.Joystick1Button18:
				JoystickButton0();
				break;
			case KeyCode.Joystick1Button19:
				JoystickButton0();
				break;
		}
	}


	//それぞれのキーの処理。overrideして
	public void JoystickButton0() { }
	public void JoystickButton1() { }
	public void JoystickButton2() { }
	public void JoystickButton3() { }
	public void JoystickButton4() { }
	public void JoystickButton5() { }
	public void JoystickButton6() { }
	public void JoystickButton7() { }
	public void JoystickButton8() { }
	public void JoystickButton9() { }
	public void JoystickButton10() { }
	public void JoystickButton11() { }
	public void JoystickButton12() { }
	public void JoystickButton13() { }
	public void JoystickButton14() { }
	public void JoystickButton15() { }
	public void JoystickButton16() { }
	public void JoystickButton17() { }
	public void JoystickButton18() { }
	public void JoystickButton19() { }

}
