using UnityEngine;
using System.Collections;
using InControl;

public class SpawnPlayer : MonoBehaviour {

	public GameObject TankPrefab;


	// Use this for initialization
	void Start () {

		int Devices = InputManager.Devices.Count;
		Devices = 2;

		for (int i = 1; i <= Devices; i++) 
		{
			var Tank = Instantiate (TankPrefab, new Vector3(1,1,0), Quaternion.identity);
			Tank.name = "Player" + i;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
