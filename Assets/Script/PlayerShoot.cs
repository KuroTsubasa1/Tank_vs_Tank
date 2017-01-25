using UnityEngine;
using System.Collections;
using InControl;

public class PlayerShoot : MonoBehaviour {

    public GameObject Parent;
    public GameObject BulletPrefab;
	public GameObject obj;
	public string Parentname = "test";

    private InputDevice joystick;
    int counter = 0;

	public void setParentName(string aName)
	{	
		print ("aName: " + aName);
		Parentname = aName;
	}

	public string getParentName()
	{	
		print ("return Parentname : " + Parentname);
		return Parentname;
	}

	// Update is called once per frame
	void Update () {

        if (counter == 0)
        {
            switch (Parent.gameObject.name)
            {
                case "Player1":
                    joystick = ControllerSetup.joystick;
                    print(gameObject.name + " is connected as joystick");
                    break;

                case "Player2":
                    joystick = ControllerSetup.joystick2;
                    print(gameObject.name + " is connected as joystick2");
                    break;

                case "Player3":
                    joystick = ControllerSetup.joystick3;
                    print(gameObject.name + " is connected as joystick3");
                    break;

                case "Player4":
                    joystick = ControllerSetup.joystick4;
                    print(gameObject.name + " is connected as joystick4");
                    break;

                case "Player5":
                    joystick = ControllerSetup.joystick5;
                    print(gameObject.name + " is connected as joystick5");
                    break;

                case "Player6":
                    joystick = ControllerSetup.joystick6;
                    print(gameObject.name + " is connected as joystick6");
                    break;

                case "Player7":
                    joystick = ControllerSetup.joystick7;
                    print(gameObject.name + " is connected as joystick7");
                    break;

                case "Player8":
                    joystick = ControllerSetup.joystick8;
                    print(gameObject.name + " is connected as joystick8");
                    break;
            }
            counter++;
        }
            if (joystick.RightTrigger.WasPressed)
		{
            joystick.Vibrate(10, 10);
			BulletPrefab.transform.rotation = new Quaternion(BulletPrefab.transform.rotation.x,PlayerController.aRot, BulletPrefab.transform.rotation.z,0);
			var killMePls = (GameObject)Instantiate(BulletPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Vector3 newRotation = new Vector3(0, Parent.transform.eulerAngles.y - 180, 0);
			killMePls.gameObject.transform.eulerAngles = newRotation;
			killMePls.transform.parent = Parent.transform;

			if (obj == null) 
			{	
				print ("set Parentname");
				obj = killMePls.transform.parent.gameObject;
				print ("obj.name: " + obj.name);
				KillPlayer kill = killMePls.GetComponent<KillPlayer>();
				kill.setParentName (obj.name);

			}

			killMePls.transform.parent = null;

			killMePls.GetComponent<Rigidbody>().velocity = Parent.transform.up * -10	;
		}
			
    }
		
}       
