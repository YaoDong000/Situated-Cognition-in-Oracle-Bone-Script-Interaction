using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nyDaCuo : MonoBehaviour
{
	public GameObject DaCuo;

	void Start()
	{
		DaCuo.SetActive(false);

	}

	public void OnLoginButtonClick()
	{
		DaCuo.SetActive(true);
	}



}