using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSwitch : MonoBehaviour
{
    [SerializeField] GameObject intactWall;
    [SerializeField] GameObject brokenWall;

    void Start()
    {
        brokenWall.SetActive(false);
    }
    public void SwitchWall()
    {
        intactWall.SetActive(false);
        brokenWall.SetActive(true);
    }
}
