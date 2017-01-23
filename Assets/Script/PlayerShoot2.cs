using UnityEngine;
using System.Collections;
using InControl;

public class PlayerShoot2 : MonoBehaviour {


    public GameObject Parent;
    public GameObject BulletPrefab;
    public GameObject obj;
    public string Parentname = "test";


    private InputDevice joystick;
    int counter = 0;

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
    void Update()
    {

        if (counter == 0)
        {
            joystick = ControllerSetup.joystick2;
            counter++;
        }

        if (joystick.RightTrigger.WasPressed)
        {
            joystick.Vibrate(10, 10);
            BulletPrefab.transform.rotation = new Quaternion(BulletPrefab.transform.rotation.x, PlayerController.aRot, BulletPrefab.transform.rotation.z, 0);
            var killMePls = (GameObject)Instantiate(BulletPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            Vector3 newRotation = new Vector3(0, Parent.transform.eulerAngles.y - 180, 0);
            killMePls.gameObject.transform.eulerAngles = newRotation;
            killMePls.transform.parent = Parent.transform;

            if (obj == null)
            {
                print("set Parentname");
                obj = killMePls.transform.parent.gameObject;
                print("obj.name: " + obj.name);
                KillPlayer kill = killMePls.GetComponent<KillPlayer>();
                kill.setParentName(obj.name);

            }

            killMePls.transform.parent = null;

            killMePls.GetComponent<Rigidbody>().velocity = Parent.transform.up * -10;
        }

    }

}
