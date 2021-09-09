using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonSound : MonoBehaviour
{
	public AudioSource myFx;
	public AudioClip hoverFx;
	public AudioClip clickFx;
	public Button buton;

	public void HoverSound()
	{
		
		if(buton.interactable == true)
		myFx.PlayOneShot(hoverFx);

	}
	public void ClickSound()
	{
		
		if (buton.interactable == true)
			myFx.PlayOneShot(clickFx);

	}

	
}
