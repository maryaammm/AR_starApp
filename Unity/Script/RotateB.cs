// source: https://www.youtube.com/watch?v=ElmzIq6stNI 
// by applying changes described here https://forum.unity.com/threads/ivirtualbuttoneventhandler-could-not-be-found.914441/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class RotateB : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject vbBtnObj;
    public Animator starAni;

    void Start()
    {
    	vbBtnObj = GameObject.Find("RotationB");
    	vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
 
    	starAni.GetComponent<Animator>();
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
    	starAni.Play("Star-Animation");
    	Debug.Log("BTN Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
    	starAni.Play("none");
    	Debug.Log("BTN Released");
    }

}
