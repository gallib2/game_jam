using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassFactory : MonoBehaviour
{
    public GameObject[] glassTypes;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateGlass",0.2f , 1f);
    }


    void CreateGlass()
    {
        int index = Random.Range(0, glassTypes.Length);
        // new Vector3(0.28f, 1f, -1.17f)

        Instantiate(glassTypes[index], transform , false);
    }

}
