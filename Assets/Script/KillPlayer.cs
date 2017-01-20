using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

	static string Parentname = "QQQQQQQQ";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void setParentName(string aParentname)
	{	
		print ("Parentname XXX " + Parentname);
		print("i was here");
		Parentname = aParentname;
		print ("Parentname ZZZ " + Parentname);
	}
		

	public void OnTriggerEnter(Collider other)
	{	
		print ("Parentname: " + Parentname);
		print ("other name: " + other.name);
		print ("other tag: " + other.tag);

		if (Parentname!= other.name && other.tag == "Player")
		{
			Destroy(other.gameObject);
		}
	}
}
