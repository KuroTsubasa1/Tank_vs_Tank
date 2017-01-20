using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

    public GameObject Parent;
    public GameObject BulletPrefab;
	public GameObject obj;
	public string Parentname = "test";

	// Use this for initialization
	void Start () {
	}

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



		/*
        if (Input.GetButtonDown("R2"))
        {
            BulletPrefab.transform.rotation = new Quaternion(BulletPrefab.transform.rotation.x,PlayerController.aRot, BulletPrefab.transform.rotation.z,0);
            print("x" + BulletPrefab.transform.rotation.x);
            print("y" + BulletPrefab.transform.rotation.y);
            print("z" + BulletPrefab.transform.rotation.z);
            var killMePls = (GameObject)Instantiate(BulletPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            killMePls.GetComponent<Rigidbody>().velocity = Parent.transform.up * -10;
        }
		*/
		if (Input.GetKeyDown(KeyCode.Space))
		{
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
