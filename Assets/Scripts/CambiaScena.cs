using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaScena : MonoBehaviour
{
	public void LoadNewScene(string scena) {
		UnityEngine.SceneManagement.SceneManager.LoadScene(scena);
	}
}
