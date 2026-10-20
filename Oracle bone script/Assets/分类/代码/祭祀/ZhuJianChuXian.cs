using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZhuJianChuXian : MonoBehaviour
{
    public GameObject TiShi;
    void Start()
    {
        
    }
    private void Update()
    {
        StartCoroutine(DelayToInvoke.DelayToInvokeDo(() =>

        {
            TiShi.SetActive(false);
        }, 3.0f));
    }

}
