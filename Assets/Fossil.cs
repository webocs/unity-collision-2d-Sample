using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fossil : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }
}
