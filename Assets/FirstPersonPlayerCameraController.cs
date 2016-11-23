using UnityEngine;
using System.Collections;

public class FirstPersonPlayerCameraController : MonoBehaviour {

    public Transform cam;
    public float mouseSensitivityX = 1;
    public float mouseSensitivityY = 1;

    public float joySensitivityX = 3;
    public float joySensitivityY = 3;

    public bool invertLookY = true;

    float camPitch = 0;

    Vector3 prevMousePosition = Vector3.zero;

    // Use this for initialization
    void Start () {
        cam = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update () {
        cameraRotation();
	}

    void cameraRotation()
    {
        Vector3 mouseDiff = Input.mousePosition - prevMousePosition;
        prevMousePosition = Input.mousePosition;

        if (mouseDiff != new Vector3(0, 0, 0))
        {
            transform.Rotate(0, mouseDiff.x * mouseSensitivityX, 0);
            camPitch += mouseDiff.y * mouseSensitivityY * (invertLookY ? -1 : 1);
            camPitch = Mathf.Clamp(camPitch, -80, 80);
            cam.localEulerAngles = new Vector3(camPitch, 0, 0);
        }
        else
        {

            //camera rotates vertically
            camPitch += (Input.GetAxis("JoyY")) * joySensitivityY;
            camPitch = Mathf.Clamp(camPitch, -80, 80);

            cam.localEulerAngles = new Vector3(camPitch, 0, 0);

            //PLAYER rotates horizontally
            transform.Rotate(0, ((Input.GetAxis("JoyX")) * joySensitivityX), 0);



            //cam.transform.Rotate(cam.eulerAngles.x, cam.eulerAngles.y +(Input.GetAxis("Joy X") * joySensitivityX), 0);
            // cam.transform.Rotate(cam.eulerAngles.x + (Input.GetAxis("Joy X") * joySensitivityX) ,0 ,0);
        }
    }
}
