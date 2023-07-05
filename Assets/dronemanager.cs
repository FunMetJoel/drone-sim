using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class dronemanager : MonoBehaviour
{
    public GameObject DronePrefab;

    public int aantalTouwRaak = 0;
    public int aantalTouwMis = 0;

    public bool RandomRichting;
    [Range(0, 180f)]
    public float richting;

    public bool RandomDroneSize;
    [Range(0.1f, 1f)]
    public float DroneSize;

    public Vector2 maxVChange;
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
        GameObject Drone = Instantiate(DronePrefab, new Vector3(Random.Range(-10f, 10f), -4.8f, 0), Quaternion.identity, this.transform);
        Drone.GetComponent<Drone>().manager = this;
        Drone.transform.localScale = new Vector3(DroneSize, DroneSize, DroneSize);
        Drone.GetComponent<Drone>().maxVChange = maxVChange;
        float a = 0;
        if (RandomRichting)
            a = Random.Range(0.25f*Mathf.PI, 0.75f * Mathf.PI);
        else
            a = richting * Mathf.Deg2Rad;
        Drone.GetComponent<Drone>().velocity = new Vector2 
            (
                10*Mathf.Cos(a),
                10 * Mathf.Sin(a)
            );

    }
}
