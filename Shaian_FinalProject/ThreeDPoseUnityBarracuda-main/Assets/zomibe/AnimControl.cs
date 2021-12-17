using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{
    public GameObject Zombieman;
    public ParticleSystem ps;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("1key"))
        {
            Zombieman.GetComponent<Animator>().Play("walk");
        }
        if (Input.GetButtonDown("2key"))
        {
            Zombieman.GetComponent<Animator>().Play("dance");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
           ps.Emit(200);
        }
    }
}
