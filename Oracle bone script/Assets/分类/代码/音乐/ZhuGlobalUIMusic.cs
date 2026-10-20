using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZhuGlobalUIMusic : MonoBehaviour
{
    public GameObject globalUIMusic;
    GameObject MyUIMusic;
    // Start is called before the first frame update
    void Start()
    {
        MyUIMusic = GameObject.FindGameObjectWithTag("ZhuPeiYue");
        if (MyUIMusic == null)
        {
            MyUIMusic = (GameObject)Instantiate(globalUIMusic);
        }
    }
}
