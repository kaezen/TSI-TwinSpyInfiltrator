using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {

	void Update () {
	}
    /// <summary>
    /// This function is called to open the attached door
    /// </summary>
  public  void Open()
    {
        transform.Rotate(Vector3.up, 90);
    }
    /// <summary>
    /// this function is called to close the attached door
    /// </summary>
    public void Close()
    {
        transform.Rotate(Vector3.up, -90);
    }
}
