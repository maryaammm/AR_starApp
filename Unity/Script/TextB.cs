﻿// source: https://www.youtube.com/watch?v=xpcyZdyO5P8

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextB : MonoBehaviour
{
    public Text Textfield;

    public void SetText(string text)
    { 
    	Textfield.text = text;
    } 
}
