using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rota : MonoBehaviour
{
    public float rotaspeed;
    // Start is called before the first frame update
    void Start()
    {
        rotaspeed = Random.Range(0.2f,0.8f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, rotaspeed, 0), Space.World);
    }
}
