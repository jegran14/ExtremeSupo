﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModoPitufo : MonoBehaviour {

    PlayerController player;
    public float time;
    public float force;
    public Vector3 scale;
    public PowerUp power;

    // Use this for initialization
    public void StartPowerUp(PlayerController player)
    {
        //Cambiar condiciones
 
        this.player = player;
        player.transform.localScale -= scale;
        player.pushForce -= force;
        StartCoroutine("CuentaAtras");
        //CuentaAtras();

    }

    // Update is called once per frame
    void Update()
    {


    }
    IEnumerator CuentaAtras()
    {

        yield return new WaitForSeconds(time);

        player.transform.localScale += scale;
        player.pushForce += force;
        power.active = false;
        //Devolver a condiciones normales
    }

}

