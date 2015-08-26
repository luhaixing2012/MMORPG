using UnityEngine;
using System.Collections;

public class RootController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnAnimatorMove()
    {
        Animator animator = gameObject.GetComponent<Animator>();

        if (animator)
        {
            Vector3 pos = gameObject.transform.position;
            pos.z += animator.GetFloat("Speed") * Time.deltaTime;
            transform.position = pos;
        }
    }
}
