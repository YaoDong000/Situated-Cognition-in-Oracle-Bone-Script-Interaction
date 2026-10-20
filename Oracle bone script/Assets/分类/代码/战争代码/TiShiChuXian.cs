using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZhanZhengTiShi : MonoBehaviour
{
	public GameObject TiShiNeiRong;

	void Start()
	{
		TiShiNeiRong.SetActive(false);
	}

	public void OnLoginButtonClick()
	{
		TiShiNeiRong.SetActive(true);
	}
}
