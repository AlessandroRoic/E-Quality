using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitTarget : MonoBehaviour
{
	bool stop=false;

	void OnCollisionEnter(Collision col) {
		if (!stop) {
			stop = true;
			Debug.Log("colpito: " + col.collider.gameObject);
			switch(col.collider.gameObject.name){
				case "tg_center":
					GameManager.instance.addPunteggio(200);
					break;
				case "tg_first":
					GameManager.instance.addPunteggio(100);
					break;
				case "tg_second":
					GameManager.instance.addPunteggio(50);
					break;
				case "tg_third":
					GameManager.instance.addPunteggio(25);
					break;
			}
		}
	}
}
