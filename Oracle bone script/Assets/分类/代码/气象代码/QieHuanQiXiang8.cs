using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QieHuanQiXiang8 : MonoBehaviour
{
    public void OnLoginButtonClick()
    {
        StartCoroutine(DelayToInvoke.DelayToInvokeDo(() =>

        {

            SceneManager.LoadScene("qixiang8");
        }, 1.5f));
    }
}


