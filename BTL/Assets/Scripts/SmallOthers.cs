using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallOthers : MonoBehaviour {
    public GameObject GM;

    //Game Objects
    //public GameObject groundObj;
    //static Animator groundAnim;

    //move
    //public ControlMove joystick;
    public float speed = 15;
    public static bool inControl = true;
    //cam
    //public Transform CameraTransform;
    //private Vector3 cameraOffset;
    //force apart
    //static public float xApart = 0;
    //static public float yApart = 0;
    //static public float xApartOrg = 0;
    //static public float yApartOrg = 0;
    //public float hNet = 0;
    //public float vNet = 0;


    //hit
    //public static int theTriggerOne = -1;
    //form
    public static int lightShape = 0;
    public static bool shapeChange = false;

    //testing
    public static bool showT3 = false;

    [Range(0.01f, 1.0f)]
    public float smoothFactor = 0.01f;

    ////UI system
    //public Text lockedRmd;


    ////earthquake
    //public bool earthquakeOn = false;
    //public GameObject EQSound;
    //public Image darkCurtain;

    // Use this for initialization
    void Start()
    {
        ////joystick = GameObject.FindWithTag("joystick").GetComponent<ControlMove>();
        //groundAnim = groundObj.GetComponent<Animator>();

        ////initialization of camera
        //CameraTransform = GameObject.FindWithTag("MainCamera").transform;
        //cameraOffset = CameraTransform.transform.position - new Vector3(0f, 0f, -50f);
    }

    // Update is called once per frame
    void Update()
    {



    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("storyText"))
        {
            if (!other.GetComponent<storyTextControl>().isTriggered)
            {
                other.GetComponent<storyTextControl>().isTriggered = true;
                //other.GetComponentInChildren<lightUpText>().turnedOn = true;
                other.gameObject.transform.GetChild(1).gameObject.GetComponent<lightUpText>().turnedOn = true;

                //showNext
                other.GetComponent<storyTextControl>().showNext();

            }

        }

        if (other.gameObject.CompareTag("puzzleText"))
        {

            if (!other.GetComponent<puzzleTextControl>().isTriggered)
            {
                other.GetComponent<puzzleTextControl>().isTriggered = true;

                //show hint
                other.GetComponent<puzzleTextControl>().showHint();
                //other.gameObject.transform.GetChild(1).gameObject.GetComponent<lightUpText>().turnedOn = true;

            }
            //if unlocked -> show next + turn on
        }



    }
}
