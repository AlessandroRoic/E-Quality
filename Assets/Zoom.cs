using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
	public Animator animator;
	public GameObject Costanza;
	public GameObject b1;
	public GameObject b2;
	public void ZoomOut() {
		Costanza.SetActive(false);
		b1.SetActive(false);
		b2.SetActive(false);
		animator.SetTrigger("Zoom");
	}
	public void changeScene() {
		GameManager.instance.changeScene("Gameplay");
	}
}
