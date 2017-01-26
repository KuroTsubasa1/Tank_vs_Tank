using UnityEngine;
using System.Collections;

public class SceneSwitcher : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(Example());
    }
    

    IEnumerator Example()
    {   
        yield return new WaitForSeconds(5);
        Application.LoadLevel(1);
    }
}
