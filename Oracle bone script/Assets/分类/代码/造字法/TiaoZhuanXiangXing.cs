using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TiaoZhuanXiangXing : MonoBehaviour
{
    public void OnLoginButtonXiangXing()
    {
        SceneManager.LoadScene("XiangXing");
    }
    public void OnLoginButtonHuiYi()
    {
        SceneManager.LoadScene("HuiYi");
    }
    public void OnLoginButtonXingSheng()
    {
        SceneManager.LoadScene("XingSheng");
    }
    public void OnLoginButtonZhiShi()
    {
        SceneManager.LoadScene("ZhiShi");

    }
    public void OnLoginButtonJiaJie()
    {
        SceneManager.LoadScene("JiaJie");

    }
    public void OnLoginButtonZhuanZhu()
    {
        SceneManager.LoadScene("ZhuanZhu");

    }
}
