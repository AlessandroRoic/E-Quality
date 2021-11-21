using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D coll) {
		GameManager.instance.changeScene("PresentazioneLivello");
	}
}
