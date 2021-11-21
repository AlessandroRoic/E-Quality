using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScri : MonoBehaviour
{
	public rotateCannon rotateCannon;

	public void OnFadeComplete() {
		rotateCannon.OnFadeComplete();
	}
}
