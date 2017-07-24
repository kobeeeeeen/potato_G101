using UnityEngine;

using System.Collections;

public class stgtama : MonoBehaviour {

	float bulletSpeed = 1f;

	// Use this for initialization
	void Start () {
		Destroy(this.gameObject, 3);
	}
	// Update is called once per frame
	void Update () {
		transform.Translate(0, 0, bulletSpeed);

		Destroy(gameObject, 10.5f);
	}
}