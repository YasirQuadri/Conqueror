using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Units : MonoBehaviour
{
    // References
    public GameObject controller;
    public GameObject moveBlock;

    // Positions
    int xPosition = -1;
    int yPosition = -1;

    // Variable to track red ,green, blue, yellow Players
    string player;

    //reference for sprites of units
    public Sprite BlueUnit, RedUnit, GreenUnit, YellowUnit;
}
