using UnityEngine;
using System.Collections;

public class TestPlayerController : MonoBehaviour {

    public float moveSpeed = 5;

    public float checkRange = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        

        //movement
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        Vector3 move = new Vector3();

        move = transform.forward*v + transform.right * h;

        transform.position += move * Time.deltaTime * moveSpeed;

        if (Input.GetButtonDown("Fire1"))
        {
            GetObject(transform.position);
        }

	}

    void GetObject(Vector3 position)
    {
        Ray ray = new Ray(position,transform.forward);
        RaycastHit target;
        

        Physics.Raycast(ray, out target,checkRange);
        Debug.DrawRay(position, transform.forward, Color.blue, 5);
        if (target.collider != null) {
            print(target.collider.name);
            if (target.collider.transform.gameObject.layer == 8)
            {
                print("FOUND A DOOR");
                target.collider.GetComponentInParent<OpenDoor>().Open();
                
            }
        }
    }
}
