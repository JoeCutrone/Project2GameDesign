﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightWhenHit : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject mushLight;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pebble")
        {
            mushLight.SetActive(true);
        }
        
    }

    private void Update()
    {
        if (mushLight.activeSelf)
            mushLight.SetActive(false);
    }
}
