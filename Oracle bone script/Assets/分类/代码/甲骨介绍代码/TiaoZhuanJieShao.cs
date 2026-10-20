using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TiaoZhuanJieShao : MonoBehaviour
{
    public void OnLoginButtonClick1()
    {

        SceneManager.LoadScene("LiShiJiaZhi");
    }
    public void OnLoginButtonClick2()
    {

        SceneManager.LoadScene("KaoGuFaJue1");
    }
    public void OnLoginButtonClick3()
    {

        SceneManager.LoadScene("WenZiTeZheng1");
    }
    public void OnLoginButtonClick4()
    {

        SceneManager.LoadScene("JiZaiNeiRong");
    }
    public void OnLoginButtonClick5()
    {

        SceneManager.LoadScene("FaZhanLiCheng1");
    }
}
