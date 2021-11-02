using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionGenerator : MonoBehaviour
{

    public Vector3 ranPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            RandomPosition(ranPosition);
            ranPosition = new Vector3(Random.Range(0, 7), Random.Range(0, 7), Random.Range(0, 7));
        }

    }

    void RandomPosition(Vector3 position)
    {
        transform.position = position;

    }
}
