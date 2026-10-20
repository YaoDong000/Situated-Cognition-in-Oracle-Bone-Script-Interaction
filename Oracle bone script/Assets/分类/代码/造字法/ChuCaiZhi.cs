using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChuCaiZhi : MonoBehaviour
{
    private void Start()
    {
        Type[] compents = { (typeof(RawImage)), typeof(Texture) };
        GameObject RawImage = new GameObject("HuiYi", compents);
    }
    
}
