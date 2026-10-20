using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZhanZhengButton : MonoBehaviour
{
    public void OnLoginButtonClick()
    {
        SceneManager.LoadScene("ZhanZheng1");
    }
}
