using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour {
	[SerializeField]GameObject monsterPrefab;
	private float createTime;

	void Awake(){
		createTime = 0.0f;
	}

	void Update () {
		if (createTime < 1.0f)
			createTime += Time.deltaTime;
		else {
			createTime = 0.0f;
			Create_Monster ();
		}
	}

	void Create_Monster(){
		GameObject clone = Instantiate (monsterPrefab);

		float fx = Random.Range (-3.0f, 3.0f);
		clone.transform.SetParent (transform);

		Monster monster = clone.GetComponent<Monster> ();
		monster.Init (new Vector3 (fx, 5.0f, 0.0f));
	}
}

