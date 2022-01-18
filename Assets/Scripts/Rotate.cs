using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, 100f) * Time.deltaTime);
    }
}

