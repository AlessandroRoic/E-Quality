using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public static GameManager instance = null;
	private static string playerName = "nomeTest";
	private int punteggio;
	private float felicita=0.5f;
	private static bool isFemmina = true;
	private int[] tiri = new int[3];
	private int next = 0;
	private static string eta="Test";
	private static string citta="Test";
	private int sceltaGiusta;
	private int sceltaSbagliata;


	void Awake() {
		//Check if instance already exists
		if (instance == null) {

			//if not, set instance to this
			instance = this;
		}
		//If instance already exists and it's not this:
		else if (instance != this) {

			//Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
			Destroy(gameObject);
		}
		//Sets this to not be destroyed when reloading scene
		DontDestroyOnLoad(gameObject);
	}

	public void insertName(Text name) {
		playerName = name.text;
    }

	public string getName() {
		return playerName;
	}
	public void addPunteggio(int punti) {
		punteggio += punti;
		tiri[next] = punti;
		next++;
		Debug.Log("punteggio="+punteggio);
	}

	public void addFelicita(float puntiFelicita) {
		felicita += puntiFelicita;
		if (felicita > 1) { felicita = 1; }
		Debug.Log("felicità= "+felicita);
	}

	public void removeFelicita(float puntiFelicita) {
		felicita -= puntiFelicita;
		if (felicita < 0) { felicita = 0; }
	}

	public int getPunteggio() {
		return punteggio;
	}

	public float getFelicita() {
		return felicita;
	}

	public void changeScene(string scenename) {
		SceneManager.LoadScene(scenename);
	}

	public bool getSesso() {
		return isFemmina;
	}
	public void setSesso(bool _isFemmina) {
		isFemmina = _isFemmina;
	}

	public int[] getTiri() {
		return tiri;
	}

	public void colpitoSceltaGiusta() {
		sceltaGiusta++;
	}

	public void colpitoSceltaSbagliata() {
		sceltaSbagliata++;
	}

	public int getSceltaGiusta() {
		return sceltaGiusta;
	}

	public int getSceltaSbagliata() {
		return sceltaSbagliata;
	}

	public void resetTiri() {
		next = 0;
		for(int i = 0; i < 3; i++) {
			tiri[i] = 0;
		}
	}

	public void setCitta(Text _citta) {
		citta = _citta.text;
	}

	public void setEta(Text _eta) {
		eta = _eta.text;
	}

	public string getCitta() {
		return citta;
	}

	public string getEta() {
		return eta;
	}
}

