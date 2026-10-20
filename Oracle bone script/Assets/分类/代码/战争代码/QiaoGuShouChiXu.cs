using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QiaoGuShouChiXu : MonoBehaviour
{
    public GameObject QiaoGuShou1;
    void Start()
    {

    }

    public void OnLoginButtonClick1()
    {
        QiaoGuShou1.SetActive(false);
    }
}
