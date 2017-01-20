using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

    public GameObject Parent;
    public GameObject BulletPrefab;

	// Use this for initialization
	void Start () {
	
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
			killMePls.GetComponent<Rigidbody>().velocity = Parent.transform.up * -10;
		}
			
    }
}       
