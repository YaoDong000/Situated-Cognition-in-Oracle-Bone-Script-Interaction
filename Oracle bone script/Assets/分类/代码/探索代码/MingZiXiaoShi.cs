using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MingZiXiaoShi : MonoBehaviour
{
    public GameObject MingZi;
    // Start is called before the first frame update
    public void OnLoginButtonClick()
    {
        MingZi.SetActive(false);
    }
}
