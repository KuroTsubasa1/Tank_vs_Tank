using UnityEngine;
using System.Collections;
using InControl;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ControllerSetup : MonoBehaviour {

    public static int DeviceCounter = 0;

    public static InputDevice joystick = null;
    public static InputDevice joystick2 = null;
    public static InputDevice joystick3 = null;
    public static InputDevice joystick4 = null;
    public static InputDevice joystick5 = null;
    public static InputDevice joystick6 = null;
    public static InputDevice joystick7 = null;
    public static InputDevice joystick8 = null;


    private void Awake()
    {
        int controllerConnected = InputManager.Devices.Count;
        
        switch(controllerConnected)
        {
            case 1:
                joystick = InputManager.Devices[0];
                print("Case: " + controllerConnected);
                break;

            case 2:
                joystick = InputManager.Devices[0];
                joystick2 = InputManager.Devices[1];
                print("Case: " + controllerConnected);
                break;

            case 3:
                joystick = InputManager.Devices[0];
                joystick2 = InputManager.Devices[1];
                joystick3 = InputManager.Devices[2];
                print("Case: " + controllerConnected);
                break;

            case 4:
                joystick = InputManager.Devices[0];
                joystick2 = InputManager.Devices[1];
                joystick3 = InputManager.Devices[2];
                joystick4 = InputManager.Devices[3];
                print("Case: " + controllerConnected);
                break;

            case 5:
                joystick = InputManager.Devices[0];
                joystick2 = InputManager.Devices[1];
                joystick3 = InputManager.Devices[2];
                joystick4 = InputManager.Devices[3];
                joystick5 = InputManager.Devices[4];
                print("Case: " + controllerConnected);
                break;

            case 6:
                joystick = InputManager.Devices[0];
                joystick2 = InputManager.Devices[1];
                joystick3 = InputManager.Devices[2];
                joystick4 = InputManager.Devices[3];
                joystick5 = InputManager.Devices[4];
                joystick6 = InputManager.Devices[5];
                print("Case: " + controllerConnected);
                break;

            case 7:
                joystick = InputManager.Devices[0];
                joystick2 = InputManager.Devices[1];
                joystick3 = InputManager.Devices[2];
                joystick4 = InputManager.Devices[3];
                joystick5 = InputManager.Devices[4];
                joystick6 = InputManager.Devices[5];
                joystick7 = InputManager.Devices[6];
                print("Case: " + controllerConnected);
                break;

            case 8:
                joystick = InputManager.Devices[0];
                joystick2 = InputManager.Devices[1];
                joystick3 = InputManager.Devices[2];
                joystick4 = InputManager.Devices[3];
                joystick5 = InputManager.Devices[4];
                joystick6 = InputManager.Devices[5];
                joystick7 = InputManager.Devices[6];
                joystick8 = InputManager.Devices[7];
                print("Case: " + controllerConnected);
                break;
        }
        
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        
    }
}
