using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JiaGuWenChuXian : MonoBehaviour
{
    public GameObject JiaGu;
	void Start()
	{
		JiaGu.SetActive(false);

	}

	public void OnLoginButtonClick()
	{
		JiaGu.SetActive(true);
	}

}
