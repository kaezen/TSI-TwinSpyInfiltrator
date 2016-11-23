using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SwitchToHacker : MonoBehaviour {

public void SwitchToHackerScene()
    {      
        SceneManager.LoadScene("HackerTest");
    }
}
