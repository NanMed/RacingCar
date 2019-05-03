using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
	public float carSpeed;
	public float maxPos = 2.10f;

	Vector3 position;
	public UIManager ui;
    // Start is called before the first frame update
    void Start()
    {
		//Access of the uimanager script
		//ui = GetComponent<UIManager>();
		//transfomr.position is the current position of the car in the scene
		position = transform.position;
    }

    float direction = -1;
    bool active = true;
    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            direction = -1;
        } else
        {
            direction = 1;
        }
        position = transform.position;
        bool down = Input.GetKey("space");
        //Increase the value of the position related to the keys
        //position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;

        position.x += direction * carSpeed * Time.deltaTime;

        //Limit the value of x (boundaries)
        position.x = Mathf.Clamp(position.x, -2.1f, 2.1f);

		transform.position = position;
        if (down)
        {
            active = false;
        } else
        {
            active = true;
        }
    
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag == "EnemyCar"){
			Destroy(gameObject);
			ui.gameOverActivated();
		}
	}
}
