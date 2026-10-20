using UnityEngine;
using System.Collections;

public class Audiomanager : MonoBehaviour
{
   
    void Awake()
    {

        DontDestroyOnLoad(this.gameObject);

    }
  
}
