using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZhuChuShiHua : MonoBehaviour
{
    public GameObject globalUIMusic;
    GameObject MyUIMusic;

    // Start is called before the first frame update
    void Start()
    {
        MyUIMusic = GameObject.FindGameObjectWithTag("ZhuPeiYue");
        Destroy(MyUIMusic, 0f);
    }
}
