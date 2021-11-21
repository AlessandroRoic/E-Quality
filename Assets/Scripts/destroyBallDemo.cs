using UnityEngine;
using System.Collections;

public class destroyBallDemo : MonoBehaviour {

    public float life;

	// Use this for initialization
	void Start()
    {
        Destroy(gameObject, life);
	}
}
