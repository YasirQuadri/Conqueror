using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    public GameObject unit;
    public GameObject fort;

    void Start()
    {
        Instantiate(unit, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(fort, new Vector3(0, 0, 0), Quaternion.identity);
    }

}
