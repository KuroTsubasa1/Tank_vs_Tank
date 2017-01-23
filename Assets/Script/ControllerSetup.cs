using UnityEngine;
using System.Collections;
using InControl;

public class ControllerSetup : MonoBehaviour {

    public static int DeviceCounter = 0;


    public static InputDevice joystick;
    public static InputDevice joystick2;
    public static InputDevice joystick3;
    public static InputDevice joystick4;
    public static InputDevice joystick5;
    public static InputDevice joystick6;
    public static InputDevice joystick7;
    private void Awake()
    {
        joystick = InputManager.Devices[0];
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        print("InputDevices" + InputManager.Devices.Count);
    }
}
