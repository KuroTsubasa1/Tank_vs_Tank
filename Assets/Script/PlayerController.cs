using UnityEngine;
using System.Collections;
using InControl;

public class PlayerController : MonoBehaviour
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

    public Material red;
    public Material blue;
    public Material yellow;
    public Material green;
    public Material pink;
    public Material orange;
    public Material black;
    public Material grey;



    // Update is called once per frame
    void Update()
    {   
       
        if (counter == 0)
        {

            Player1 = this.gameObject;
            CC = this.gameObject.GetComponent<CharacterController>();

			switch (gameObject.name) 
			{
			    case "Player1":
				    joystick = ControllerSetup.joystick;
                    print(gameObject.name + " is connected as joystick");
                    GetComponent<Renderer>().material = red;
                    break;

				case "Player2":
				    joystick = ControllerSetup.joystick2;
                    print(gameObject.name + " is connected as joystick2");
                    GetComponent<Renderer>().material = blue;
                    break;

				case "Player3":
					joystick = ControllerSetup.joystick3;
                    print(gameObject.name + " is connected as joystick3");
                    GetComponent<Renderer>().material = yellow;
                    break;

				case "Player4":
                    joystick = ControllerSetup.joystick4;
                    print(gameObject.name + " is connected as joystick4");
                    GetComponent<Renderer>().material = green;
                    break;

				case "Player5":
					joystick = ControllerSetup.joystick5;
                    print(gameObject.name + " is connected as joystick5");
                    GetComponent<Renderer>().material = pink;
                    break;

				case "Player6":
					joystick = ControllerSetup.joystick6;
                    print(gameObject.name + " is connected as joystick6");
                    GetComponent<Renderer>().material = orange;
                    break;

				case "Player7":
					joystick = ControllerSetup.joystick7;
                    print(gameObject.name + " is connected as joystick7");
                    GetComponent<Renderer>().material = black;
                    break;

                case "Player8":
                    joystick = ControllerSetup.joystick8;
                    print(gameObject.name + " is connected as joystick8");
                    GetComponent<Renderer>().material = grey;
                    break;
            }
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