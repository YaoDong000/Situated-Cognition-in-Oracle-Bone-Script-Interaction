using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TiaoZhuanSampleScene : MonoBehaviour
{
    public void OnLoginButtonClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
