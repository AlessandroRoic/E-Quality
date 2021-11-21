using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class rotateCannon : MonoBehaviour {

	public GameObject cannonBall;
	public float forceMultiplier = 150;
	private bool isRotationActive = true;
	private GameObject[] balls;
	private float cannonAngle;
	private float time;
	// Use this for initialization
	private int next = 0;
	public Animator animator;
	private string scene;

	void Start () {
		cannonAngle = 90;
		balls = new GameObject[3];
		for (int i = 0; i < 3; i++) {
			balls[i] = (GameObject)Instantiate(cannonBall);
			balls[i].transform.SetParent(GameObject.Find("NON_UI").transform);
		}
		balls[0].transform.position = transform.position + new Vector3(0, 1,0.25f);
		balls[1].transform.position = transform.position + new Vector3(2, 1, 0.25f);
		balls[2].transform.position = transform.position + new Vector3(4, 1, 0.25f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.eulerAngles = new Vector3(90, 270, cannonAngle);
		if (isRotationActive) {
			time+=1.5f;
			cannonAngle = Mathf.PingPong(time, 180); }
		if(GameObject.Find("like 1(Clone)") == null) {
			fire(0);
		}
	}

	public void setRotationActive(bool active) {
		isRotationActive = active;
	}

	public void fire(float _fireForce) {
		if (next<3) {
			float radAngle = (cannonAngle) * Mathf.Deg2Rad;
			float ballForce = _fireForce * forceMultiplier;
			Debug.Log("power= " + _fireForce + "Time= " + Time.time);
			Vector3 ballDirection = new Vector3(ballForce * Mathf.Cos(radAngle), ballForce, ballForce * Mathf.Sin(radAngle));
			//Debug.Log("X: " + (ballForce * Mathf.Cos(radAngle)) + " Y: " + ballForce * Mathf.Sin(radAngle) + " Z: " + ballForce + " ANGLE: "+radAngle);
			balls[next].GetComponent<Rigidbody>().useGravity = true;
			balls[next].GetComponent<HitTarget>().enabled = true;
			balls[next].GetComponent<BoxCollider>().enabled = true;
			balls[next].GetComponent<Rigidbody>().AddForce(ballDirection);
			next++;
			chargeBall();
		} else {
			if (GameManager.instance.getSceltaGiusta() > GameManager.instance.getSceltaSbagliata()) {
				GameObject.Find("NON_UI").SetActive(false);
				animator.SetTrigger("FadeOut");
				GameManager.instance.addFelicita(0.2f);
				scene = "PostScenaGiusta";
				//GameManager.instance.changeScene("PostScenaGiusta"); //PostScenaGiusta 
			}
			else if(GameManager.instance.getSceltaGiusta() < GameManager.instance.getSceltaSbagliata()) {
				GameObject.Find("NON_UI").SetActive(false);
				animator.SetTrigger("FadeOut");
				GameManager.instance.removeFelicita(0.2f);
				scene = "PostScenaSbagliata";
				//GameManager.instance.changeScene("PostScenaSbagliata"); //PostScenaSbagliata 
			}
			else {
				GameManager.instance.changeScene("Gameplay"); //Se non prende nulla
			}
		}
	}

	public void OnFadeComplete() {
		GameManager.instance.changeScene(scene);
	}

	public void chargeBall() {
		if(next == 1) {
			balls[1].transform.position= this.transform.position +new Vector3(0, 1, 0.25f);
			balls[2].transform.position = this.transform.position + new Vector3(2, 1, 0.25f);
		}
		else if(next == 2) {
			balls[2].transform.position = this.transform.position + new Vector3(0, 1, 0.25f);
		}
	}
	
}
