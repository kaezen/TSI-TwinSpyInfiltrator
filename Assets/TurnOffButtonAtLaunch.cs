using UnityEngine;
using System.Collections;

public class TurnOffButtonAtLaunch : MonoBehaviour
{
    public GameObject button;

    // Use this for initialization
    void Start()
    {
        //button = this.GetComponentInParent<GameObject>();
        button.SetActive(false);
        
        
    }
}
