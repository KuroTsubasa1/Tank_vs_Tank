using UnityEngine;
using System.Collections;

public class PlayerMine : MonoBehaviour {

	public GameObject Parent;
	public GameObject MinePrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.E))
		{
			MinePrefab.transform.rotation = new Quaternion(MinePrefab.transform.rotation.x,PlayerController.aRot, MinePrefab.transform.rotation.z,0);
			var MinePLS = (GameObject)Instantiate(MinePrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Vector3 newRotation = new Vector3(-90, Parent.transform.eulerAngles.y - 180, 0);
			MinePLS.gameObject.transform.eulerAngles = newRotation;
			MinePLS.GetComponent<Rigidbody>().velocity = Parent.transform.up * 2;
			// MinePLS.gameObject.GetComponent<Renderer> ().material.color = PlayerController.PlayerColor;
		}
	}
}
