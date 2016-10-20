using UnityEngine;
using System.Collections;

public class BlockGreen : MonoBehaviour {
	public GameObject brokenBlocksPrefab;
	public float hardness=5f;
	void OnCollisionEnteR(Collision collisionInfo){
		if (collisionInfo.relativeVelocity.magnitude >hardness) {
			Instantiate(brokenBlocksPrefab, transform.position, brokenBlocksPrefab.transform.rotation);
			Destroy (gameObject);
		}
	}
}