using UnityEngine;
using System.Collections;

public class followBehaviour : MonoBehaviour {

    GameObject player;
    public float speed = 50f;
	// Use this for initialization
	void Start () {
       player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.LookAt(player.transform);
        this.transform.Translate(Vector3.forward*Time.deltaTime*speed);

	}
}
