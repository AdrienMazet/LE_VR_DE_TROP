using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    List<ParticleSystem> ps;
    // Start is called before the first frame update
    void Start()
    {
        ParticleSystem[] t = GetComponentsInChildren<ParticleSystem>();
        ps = t.OfType<ParticleSystem>().ToList();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (ParticleSystem p in ps)
        {
            if (p.isEmitting)
            {
                BroadcastMessage("addToCurrentCombination", p.gameObject.name);
            }
        }
    }
}
