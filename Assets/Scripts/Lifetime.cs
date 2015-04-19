using UnityEngine;
using System.Collections;

public class Lifetime : MonoBehaviour {

	public float time = Mathf.Infinity;

	// Use this for initialization
	void Start () {
		if (time != Mathf.Infinity)
			Destroy(gameObject, time);
	}
}
