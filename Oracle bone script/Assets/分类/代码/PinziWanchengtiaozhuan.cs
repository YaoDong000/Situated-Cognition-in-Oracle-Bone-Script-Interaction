using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PinziWanchengtiaozhuan : MonoBehaviour
{
    public GameObject CaiMiao;
    public GameObject CaiRen;
    public GameObject CaiNiu;


    public void OnLoginButtonClick()
        {
            if (CaiMiao.GetComponent<UnityEngine.UI.Image>().enabled == true&& CaiNiu.GetComponent<UnityEngine.UI.Image>().enabled == true&& CaiMiao.GetComponent<UnityEngine.UI.Image>().enabled == true)
        {
                SceneManager.LoadScene("nongye3");
            }

        }
    public void OnLoginButtonClick2()
    {
     
            SceneManager.LoadScene("nongye");
        

    }
}

