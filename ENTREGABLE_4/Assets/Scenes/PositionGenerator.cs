using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionGenerator : MonoBehaviour
{
    public int randomPosition;
    public int randomPositionX;
    public int randomPositionY;
    public int randomPositionZ;

    // Start is called before the first frame update
    void Start()
    {
        randomPositionX = Random.Range(0, 7);
        randomPositionY = Random.Range(0, 7);
        randomPositionZ = Random.Range(0, 7);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transformPosition = new  Vector3(randomPositionX, randomPositionY, randomPositionZ);
        }


    }
}
