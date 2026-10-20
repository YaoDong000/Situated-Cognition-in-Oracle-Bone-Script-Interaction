using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuoWuDaAn : MonoBehaviour
{
	public GameObject CuoKuangKuang;
	public GameObject CuoKuangKuang1;
	public GameObject CuoKuangKuang2;

	void Start()
	{
		CuoKuangKuang.SetActive(false);
		CuoKuangKuang1.SetActive(false);
		CuoKuangKuang2.SetActive(false);
	}

	public void OnLoginButtonClick()
	{
		CuoKuangKuang.SetActive(true);
	}
	public void OnLoginButtonClick1()
	{
		CuoKuangKuang1.SetActive(true);
	}
	public void OnLoginButtonClick2()
	{
		CuoKuangKuang2.SetActive(true);
	}
}
