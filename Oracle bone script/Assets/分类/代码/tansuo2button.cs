using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class tansuo2button : MonoBehaviour
{
    public GameObject VP1;
    public GameObject VP2;
  

    void Start()
    {
        VP1.SetActive(true);
        VP2.SetActive(false);
        


    }
    public void OnLoginButtonClick()
    {
        VP1.SetActive(false);
        VP2.SetActive(true);
       


    }
}
