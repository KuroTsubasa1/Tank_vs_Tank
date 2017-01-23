using UnityEngine;
using System.Collections;
using InControl;
public class PlayerController2 : MonoBehaviour
{
    private InputDevice joystick;

    public GameObject Player1;
    public CharacterController CC;
    public static Color PlayerColor;
    public static float aRot;
    int gravity = 20;

    float jumpspeed = 0;
    bool jumped = false;

    int fall = 1;

    int counter = 0;

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if(counter == 0)
        {
            Player1 = this.gameObject;
            CC = this.gameObject.GetComponent<CharacterController>();
            joystick = ControllerSetup.joystick2;
            counter++;
        }

        aRot = this.transform.rotation.y;
        CC.SimpleMove(new Vector3(0, 0, fall) * Time.deltaTime);
        if (!CC.isGrounded)
        {
            fall = 1;
            CC.SimpleMove(new Vector3(0, 0, fall));
        }
        else
        {
            fall = 0;
        }

        if (joystick.Action1 && CC.isGrounded)
        {
            jumped = true;
            jumpspeed = 2;
            print("Pressed Square");
            print("jumped = true");
        }

        if (jumped)
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

        if (joystick.LeftStickUp)
        {
            transform.Translate(Vector3.down * 1 * Time.deltaTime);
        }

        if (joystick.LeftStickDown)
        {
            transform.Translate(Vector3.up * 1 * Time.deltaTime);
        }

        if (joystick.LeftStickLeft)
        {
            transform.Rotate(Vector3.back * 100 * Time.deltaTime);
        }

        if (joystick.LeftStickRight)
        {
            transform.Rotate(Vector3.forward * 100 * Time.deltaTime);
        }


        if (joystick.DPadUp)
        {
            transform.Translate(Vector3.down * 1 * Time.deltaTime);
        }

        if (joystick.DPadDown)
        {
            transform.Translate(Vector3.up * 1 * Time.deltaTime);
        }

        if (joystick.DPadLeft)
        {
            transform.Rotate(Vector3.back * 100 * Time.deltaTime);
        }

        if (joystick.DPadRight)
        {
            transform.Rotate(Vector3.forward * 100 * Time.deltaTime);
        }

    }

}