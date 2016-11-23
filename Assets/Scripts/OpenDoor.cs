using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {

    bool _closed = true;

	void Update () {
	}
    /// <summary>
    /// This function is called to open the attached door
    /// </summary>
  void Open()
    {
        transform.Rotate(Vector3.up, 90);
    }
    /// <summary>
    /// this function is called to close the attached door
    /// </summary>
    void Close()
    {
        transform.Rotate(Vector3.up, -90);
    }

    public void Move()
    {
        if (_closed)
        {
            _closed = false;
            Open();
        }
        else
        {
            _closed = true;
            Close();
        }
    }
}
