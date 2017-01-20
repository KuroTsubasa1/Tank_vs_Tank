using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public GameObject Player1;
    //public Rigidbody rb1;
    public CharacterController CC;
	public static Color PlayerColor;
    public static float aRot;
    int gravity = 20;

    float jumpspeed = 0;
    bool jumped = false;

    int fall = 1;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        aRot = this.transform.rotation.y;
        CC.SimpleMove(new Vector3(0, 0, fall) * Time.deltaTime);
        if (!CC.isGrounded)
        {
            fall = 1;
            CC.SimpleMove(new Vector3(0, 0, fall));
        }else
        {
            fall = 0;
        }
        
		/*
        if (Input.GetButtonDown("Square") && CC.isGrounded)
        {
            jumped = true;
            jumpspeed = 2;
            print("Pressed Square");
            print("jumped = true");
        }

        if(jumped)
        {
            print("in jumped if");
            if (jumpspeed > 0)
            {
                print("in jumpspeed > 0");
                jumpspeed -= 5 * Time.deltaTime;
                transform.Translate(Vector3.forward * jumpspeed * Time.deltaTime);
            }
            else
            {
                print("jumped false");
                jumped = false;
            }

            
        }

        if (Input.GetAxisRaw("DPad UD") > 0)
        {
            transform.Translate(Vector3.down * 1 * Time.deltaTime);
        }

        if (Input.GetAxisRaw("DPad UD") < 0)
        {
            transform.Translate(Vector3.up * 1 * Time.deltaTime);
        }

        if(Input.GetButton("L1"))
        {
           transform.Translate(Vector3.down * 1 * Time.deltaTime);
        }

        if (Input.GetButton("R1"))
        {
            transform.Translate(Vector3.up * 1 * Time.deltaTime);
        }

        
        if (Input.GetAxisRaw("DPad LR") > 0)
        {
            transform.Translate(Vector3.left * 1 * Time.deltaTime);
        }

        if (Input.GetAxisRaw("DPad LR") < 0)
        {
            transform.Translate(Vector3.right * 1 * Time.deltaTime);
        }


        if (Input.GetAxisRaw("DPad LR") > 0)
        {
            transform.Rotate(Vector3.forward * 50 * Time.deltaTime);
        }

        if (Input.GetAxisRaw("DPad LR") < 0)
        {
            transform.Rotate(Vector3.back * 50 * Time.deltaTime);
        }
		*/

		if (Input.GetKey(KeyCode.W)) 
		{
			transform.Translate(Vector3.down * 1 * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.S)) 
		{
			transform.Translate(Vector3.up * 1 * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.A)) 
		{
			transform.Rotate(Vector3.forward * 50 * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.D)) 
		{
			transform.Rotate(Vector3.back * 50 * Time.deltaTime);
		}
    }

		
}
