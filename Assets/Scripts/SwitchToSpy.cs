using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SwitchToSpy : MonoBehaviour {

 public void SwitchToSpyScene()
    {
        SceneManager.LoadScene("3DTestRoom01");
    }
}
