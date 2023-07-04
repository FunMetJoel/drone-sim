using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class dronemanager : MonoBehaviour
{
    public GameObject DronePrefab;

    public int aantalTouwRaak = 0;
    public int aantalTouwMis = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SommonDrone();
    }

    public void SommonDrone()
    {
        GameObject Drone = Instantiate(DronePrefab, new Vector3(Random.Range(-10, 10), -4, 0), Quaternion.identity, this.transform);
        Drone.GetComponent<Drone>().manager = this;
        float a = Random.Range(0.25f*Mathf.PI, 0.75f * Mathf.PI);
        Drone.GetComponent<Drone>().velocity = new Vector2 
            (
                10*Mathf.Cos(a),
                10 * Mathf.Sin(a)
            );

    }
}
