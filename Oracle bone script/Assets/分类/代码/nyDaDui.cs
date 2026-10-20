using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nyDaDui : MonoBehaviour
{
	public GameObject DaDui;

	void Start()
	{
		DaDui.SetActive(false);
		


	}

	public void OnLoginButtonClick()
    {
		DaDui.SetActive(true);
		

	}
	

	
}
