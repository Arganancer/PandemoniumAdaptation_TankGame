﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAutoDestroy : MonoBehaviour {
	void Start () {
		Destroy (transform.parent.gameObject, GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length); 
	}
}
