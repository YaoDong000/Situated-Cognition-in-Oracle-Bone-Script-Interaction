using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZaoZiShiPin : MonoBehaviour
{
    public GameObject XiangXing;
    public GameObject HuiYi;
    public GameObject XingSheng;
    public GameObject ZhiShi;
    public GameObject JiaJie;
    public void OnLoginButtonClick1()
    {
        HuiYi.SetActive(false);
        XingSheng.SetActive(false);
        ZhiShi.SetActive(false);
        JiaJie.SetActive(false);
        XiangXing.SetActive(true);
        


    }
    public void OnLoginButtonClick2()
    {
       XingSheng.SetActive(false);
        ZhiShi.SetActive(false);
        JiaJie.SetActive(false);
        XiangXing.SetActive(false);
       
        HuiYi.SetActive(true);
        
    }
    public void OnLoginButtonClick3()
    {
        HuiYi.SetActive(false);
        ZhiShi.SetActive(false);
        JiaJie.SetActive(false);
        XiangXing.SetActive(false);
      
        XingSheng.SetActive(true);
        
    }
    public void OnLoginButtonClick4()
    {
       HuiYi.SetActive(false);
        XingSheng.SetActive(false);
        JiaJie.SetActive(false);
        XiangXing.SetActive(false);
        ZhiShi.SetActive(true);
      
    }
    public void OnLoginButtonClick5()
    {
        HuiYi.SetActive(false);
        XingSheng.SetActive(false);
        ZhiShi.SetActive(false);
        XiangXing.SetActive(false);
        JiaJie.SetActive(true);
       
    }
   
}
