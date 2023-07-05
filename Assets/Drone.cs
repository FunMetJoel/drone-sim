using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
    public dronemanager manager;
    public Rigidbody2D rb;
    public Vector2 velocity;
    public Vector2 maxVChange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = velocity;

        velocity = velocity + maxVChange * Random.Range(-0.9f, 0.9f) * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("OnTriggerEnter2D");
        if(col.gameObject.layer == LayerMask.NameToLayer("Finish"))
            manager.aantalTouwMis++;
        if (col.gameObject.layer == LayerMask.NameToLayer("Kabel"))
            manager.aantalTouwRaak++;
        Destroy(this.gameObject);
    }
}
