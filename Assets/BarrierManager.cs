using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierManager : MonoBehaviour
{
    public GameObject BarrierPrefab;

    public Vector2[] pattern;
    public bool updateBarrier;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (updateBarrier)
            SetBarriers();

    }

    private void SetBarriers()
    {
        updateBarrier = false;
        for (int i = this.transform.childCount - 1; i >= 0; i--)
        {
            Object.Destroy(this.transform.GetChild(i).gameObject);
        }

        float pos = -15f;
        float rHeight = 0;
        while (pos < 15f)
        {
            foreach (Vector2 space in pattern)
            {
                GameObject Barrier = Instantiate(BarrierPrefab, new Vector3(pos, rHeight, 0), Quaternion.identity, this.transform);
                pos += space.x;
                rHeight = space.y;
            }
        }
        
    }
}
