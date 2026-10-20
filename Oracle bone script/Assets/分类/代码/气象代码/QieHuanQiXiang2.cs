using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QieHuanQiXiang2 : MonoBehaviour
{
    public void OnLoginButtonClick()
    {
        StartCoroutine(DelayToInvoke.DelayToInvokeDo(() =>

        {

            SceneManager.LoadScene("qixiang2");
        }, 1.5f));
    }
}
