using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IMenu_Input : MonoBehaviour {

	private KeyCode[] useKey;

	public void setUseKey( KeyCode[] setkey ) {
		useKey = null;
		useKey = setkey;
		setkey = null;
	}

	//平行方向にスティックが倒れているか
	public bool horizontalAxisHandler {
		get {
			bool pressedHorizontal = false;
			if( Mathf.Abs(Input.GetAxis("Horizontal")) == 1 ) {
				pressedHorizontal = true;
			}
			return pressedHorizontal;
		}
	}

	//垂直方向にスティックが倒れているか
	public bool pressedVerticalAxisHandler {
		get {
			bool pressedVertical = false;
			if( Mathf.Abs(Input.GetAxis( "Vertical" )) == 1 ) {
				pressedVertical = true;
			}
			return pressedVertical;
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
