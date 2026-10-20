using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JiangJie : MonoBehaviour
{
    public GameObject WenTi;
    public GameObject TiShiAnNiu;

    public void OnLoginButtonClick1()
    {

        WenTi.SetActive(false);
        TiShiAnNiu.SetActive(false);

    }
}
