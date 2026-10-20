
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DongHuaBoFang : MonoBehaviour
{
    private List<Object> test;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.speed = 0.0f;
    }
    public void OnLoginButtonClick()
    {
        animator.speed = 1.0f;
    }
}
