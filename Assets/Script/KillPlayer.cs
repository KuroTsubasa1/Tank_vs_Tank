using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

	public GameObject Player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter(Collider other)
	{
		if (!other.name.Equals(Player.name) && other.tag == "Player") 
		{
			Destroy(other.gameObject);
		}
	}
}
