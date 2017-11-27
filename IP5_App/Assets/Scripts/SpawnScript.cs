using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

    int count = 0;
    public GameObject completedMarker1;

	// Use this for initialization
	void Start () {

        InvokeRepeating("spwan", 0, 1000000);
	}

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Diamondo")
                {
                    Destroy(completedMarker1, 0.4f);
                    count++;
                }
            }
        }
    }
    void spwan()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-30.0f, 30.0f), Random.Range(-20.0f, 20.0f), Random.Range(5.0f, 5.0f));
        Instantiate(completedMarker1, randomPosition, Quaternion.Euler(0, Random.Range(-110.0f, 110.0f), 0));
    }
}

