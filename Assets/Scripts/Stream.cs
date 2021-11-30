using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stream : MonoBehaviour
{
    ParticleSystem ps;
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (Vector3.Angle(Vector3.down, transform.forward) <= 90f)
        { 
            ps.Play();
        }
        else
        {
            ps.Stop();
        }
    }
}
