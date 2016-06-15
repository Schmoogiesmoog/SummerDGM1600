using UnityEngine;
using System.Collections;

public class MoveWithWhileLoop : MonoBehaviour {

	public float xDistance = 10;
	Vector3 pos;

	// Update is called once per frame
	void Update () {

		while (pos.x <= xDistance) {
			pos.x += 0.1f;
		}
		transform.position = pos;
		print (pos.x);
	}
}
