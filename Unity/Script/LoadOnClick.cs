// source: https://learn.unity.com/tutorial/live-sessions-on-ui#5c7f8528edbc2a002053b4b3

using UnityEngine;
using System.Collections;

public class LoadOnClick : MonoBehaviour {

   
    public void LoadScene(int level)
    {
       
        Application.LoadLevel(level);
    }
}