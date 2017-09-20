using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Menu_Input : MonoBehaviour {

	[SerializeField]
	private KeyCode[] useKey;


	private bool pressedHorizontalAxis {
		get {
			bool pressedHorizontal = false;
			if( Mathf.Abs(Input.GetAxis("Horizontal")) == 1 ) {
				pressedHorizontal = true;
			}
			return pressedHorizontal;
		}
	}

	private bool pressedVerticalAxis {
		get {
			bool pressedVertical = false;
			if( Mathf.Abs(Input.GetAxis( "Vertical" )) == 1 ) {
				pressedVertical = true;
			}
			return pressedVertical;
		}
	}


	KeyCode getKeyCode() {
		KeyCode targetKey = KeyCode.A;

		for( int i = 0; i < useKey.Length; i++ ) {
			if( Input.GetKeyDown( useKey[i] ) ) {
				targetKey = useKey[i];
			}
		}

		return targetKey;
	}

	void checkKey() {
		KeyCode pressedKey = getKeyCode();
		switch( pressedKey ) {
			case KeyCode.Joystick1Button0:

				break;
			case KeyCode.Joystick1Button1:
				break;
			case KeyCode.Joystick1Button2:
				break;
			case KeyCode.Joystick1Button3:
				break;
			case KeyCode.Joystick1Button4:
				break;
			case KeyCode.Joystick1Button5:
				break;
			case KeyCode.Joystick1Button6:
				break;
			case KeyCode.Joystick1Button7:
				break;
			case KeyCode.Joystick1Button8:
				break;
			case KeyCode.Joystick1Button9:
				break;
			case KeyCode.Joystick1Button10:
				break;
			case KeyCode.Joystick1Button11:
				break;
			case KeyCode.Joystick1Button12:
				break;
			case KeyCode.Joystick1Button13:
				break;
			case KeyCode.Joystick1Button14:
				break;
			case KeyCode.Joystick1Button15:
				break;
			case KeyCode.Joystick1Button16:
				break;
			case KeyCode.Joystick1Button17:
				break;
			case KeyCode.Joystick1Button18:
				break;
			case KeyCode.Joystick1Button19:
				break;
		}
	}

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
