using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallSpike : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rg2d;
    [SerializeField]int timetodelay;
    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timetodelay) {
            rg2d.gravityScale = 1;
        }
    }
}
