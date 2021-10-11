using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterSeconds : MonoBehaviour {

    public float WaitTillDestroy = 0.5f;

	void Start () {
        Destroy(gameObject, WaitTillDestroy);
	}
}
