using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackMove : MonoBehaviour
{
	public float speed;
	//Go down and go up again and again
	Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		offset = new Vector2(0, Time.time * speed);
		//Put the image track to move
		GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
