using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class chushihua : MonoBehaviour
{
    public GameObject globalUIMusic;
    GameObject MyUIMusic;

    // Start is called before the first frame update
    void Start()
    {
        MyUIMusic = GameObject.FindGameObjectWithTag("GlobalUIMusic");
        Destroy(MyUIMusic, 0f) ;
    }

}
