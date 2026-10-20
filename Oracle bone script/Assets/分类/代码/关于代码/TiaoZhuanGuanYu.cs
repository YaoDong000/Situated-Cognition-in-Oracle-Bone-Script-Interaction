using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TiaoZhuanGuanYu : MonoBehaviour
{
    public void OnLoginButtonClick()
    {
        SceneManager.LoadScene("GuanYu");
    }
}
