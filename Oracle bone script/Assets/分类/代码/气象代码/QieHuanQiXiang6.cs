using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QieHuanQiXiang6 : MonoBehaviour
{
    public void OnLoginButtonClick()
    {
        StartCoroutine(DelayToInvoke.DelayToInvokeDo(() =>

        {

            SceneManager.LoadScene("qixiang6");
        }, 1.5f));
    }
}
