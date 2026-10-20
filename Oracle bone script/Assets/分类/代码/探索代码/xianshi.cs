using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class xianshi : MonoBehaviour
{
    public InputField inputName;
    // Start is called before the first frame update
    void Start()
    {
        inputName = transform.Find("InputField").GetComponent<InputField>();

        //transform.GetComponent<InputField>().onEndEdit.AddListener(End_Value);
        
    }

    public void End_Value(string inputName)
    {
        GameObject.Find("Canvas/Text").GetComponent<Text>().text = inputName;
        print("输出成功" );
    }
}
