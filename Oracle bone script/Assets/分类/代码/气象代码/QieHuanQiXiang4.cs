using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class QieHuanQiXiang4 : MonoBehaviour
{
   
    public void OnLoginButtonClick()
    {
        StartCoroutine(DelayToInvoke.DelayToInvokeDo(() =>

        {

            SceneManager.LoadScene("qixiang4");
        }, 1.5f));
    }
    


}

