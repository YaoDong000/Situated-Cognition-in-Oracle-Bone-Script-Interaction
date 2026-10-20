using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalUIMusic : MonoBehaviour
{
    public GameObject globalUIMusic;
    GameObject MyUIMusic;
    // Start is called before the first frame update
    void Start()
    {
        MyUIMusic = GameObject.FindGameObjectWithTag("GlobalUIMusic");
        if(MyUIMusic == null)
        {
            MyUIMusic = (GameObject)Instantiate(globalUIMusic);
        }
    }
}
