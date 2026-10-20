using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_TextField : MonoBehaviour
{
    void OnGUI()
    {
        GUI.TextField(new Rect(0, 0, 100, 20), "Text");

    }
}
