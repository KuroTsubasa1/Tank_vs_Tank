using UnityEngine;
using System.Collections;
using InControl;

public class SpawnPlayer : MonoBehaviour {

	public GameObject TankPrefab;


	// Use this for initialization
	void Start () {

		int Devices = InputManager.Devices.Count;
        
        for (int i = 1; i <= Devices; i++) 
		{
            Quaternion A = new Quaternion(0, -90, -90, 0);
			var Tank = Instantiate (TankPrefab, new Vector3(i,1,0), A);
			Tank.name = "Player" + i;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
