using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TuoZhuaiWanCheng : MonoBehaviour
{
    public GameObject Fang;
    public GameObject You;
    public GameObject Ding;
    public void OnLoginButtonClick()
    {
        if (Fang.activeInHierarchy&& You.activeInHierarchy && Ding.activeInHierarchy)
        {
            SceneManager.LoadScene("JiSi3");
        }

    }

}
