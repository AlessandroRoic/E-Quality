using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyLike : MonoBehaviour
{
	public bool sceltaSbagliata;
	void OnCollisionEnter(Collision col) {
		if (sceltaSbagliata) {
			GameManager.instance.colpitoSceltaSbagliata();
		} else {
			GameManager.instance.colpitoSceltaGiusta();
		}
		//GameObject obj = Instantiate(col.gameObject);
		//obj.transform.position = col.contacts[0].point + new Vector3(0, 4, 0) ;
		//obj.GetComponent<Rigidbody>().useGravity = false;
		//obj.GetComponent<HitTarget>().enabled = true;
		//obj.GetComponent<BoxCollider>().enabled = false;
		col.gameObject.name = "down";
		col.gameObject.GetComponent<Rigidbody>().isKinematic = true;
		col.gameObject.GetComponent<HitTarget>().enabled = false;
		col.gameObject.GetComponent<BoxCollider>().enabled = false;
		//Destroy(col.collider.gameObject);
	}
}
