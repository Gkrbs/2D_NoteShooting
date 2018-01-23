using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteManager : MonoBehaviour {
	[SerializeField] GameObject alertlinePrefab;
	[SerializeField] GameObject meteoritePrefab;

	void Awake(){
		StartCoroutine (Create_Meteorite());
	}

	IEnumerator Create_Meteorite(){
		float time = Random.Range (1, 5);
		yield return new WaitForSeconds (time);

		float fx = Random.Range (-3.0f, 3.0f);

		GameObject cloneAL = Instantiate (alertlinePrefab);
		Alert_Line alertLine = cloneAL.GetComponent<Alert_Line> ();
		alertLine.Init (new Vector3 (fx, 0.0f, 0.0f));

		yield return new WaitForSeconds (1.0f);

		GameObject cloneM = Instantiate (meteoritePrefab);
		Meteorite meteorite = cloneM.GetComponent<Meteorite> ();
		meteorite.Init (new Vector3 (fx, 5.0f, 0.0f));

		Destroy (cloneAL);

		StartCoroutine (Create_Meteorite ());
	}
}
