using UnityEngine;
using System.Collections;

public class BlockBlue : MonoBehaviour {
	public float rotateSpeed=60f;
	private bool isRotate=false;
	void OnMouseDown () {
		if (isRotate)
			return;
		isRotate = true;
		StartCoroutine ("RotateDestory");
	}


	IEnumerator RotateDestory(){
		float angle = 0;
		while (angle<90) {
			angle=angle+rotateSpeed*Time.deltaTime;
			transform.Rotate (0, rotateSpeed * Time.deltaTime,0);
			yield return null;
		}
		Destroy (gameObject);
	}
}
