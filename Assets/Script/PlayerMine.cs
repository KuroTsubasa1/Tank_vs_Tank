using UnityEngine;
using System.Collections;
using InControl;

public class PlayerMine : MonoBehaviour {

    public GameObject Parent;
    public GameObject obj;
    public GameObject MinePrefab;
    public string Parentname = "test";


    private InputDevice joystick;

    private void Awake()
    {
        joystick = InputManager.Devices[0];
    }

    public void setParentName(string aName)
    {
        print("aName: " + aName);
        Parentname = aName;
    }

    public string getParentName()
    {
        print("return Parentname : " + Parentname);
        return Parentname;
    }

	
	// Update is called once per frame
	void Update () {
	
	/*	if (joystick.LeftTrigger.WasPressed)
		{
			MinePrefab.transform.rotation = new Quaternion(MinePrefab.transform.rotation.x,PlayerController.aRot, MinePrefab.transform.rotation.z,0);
			var MinePLS = (GameObject)Instantiate(MinePrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Vector3 newRotation = new Vector3(-90, Parent.transform.eulerAngles.y - 180, 0);
			MinePLS.gameObject.transform.eulerAngles = newRotation;
            MinePLS.transform.parent = Parent.transform;

            if (obj == null)
            {
                print("set Parentname");
                obj = MinePLS.transform.parent.gameObject;
                print("obj.name: " + obj.name);
                KillPlayer mine = MinePLS.GetComponent<KillPlayer>();
                mine.setParentName(obj.name);  
            }

            MinePLS.transform.parent = null;

            MinePLS.GetComponent<Rigidbody>().velocity = Parent.transform.up * 2;
        }*/
	}
}
