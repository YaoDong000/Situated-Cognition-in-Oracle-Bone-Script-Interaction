using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZhengQueDaAn : MonoBehaviour
{
	public GameObject DuiKuangKuang;

	void Start()
	{
		DuiKuangKuang.SetActive(false);
	}

	public void OnLoginButtonClick()
	{
		DuiKuangKuang.SetActive(true);
	}

}
