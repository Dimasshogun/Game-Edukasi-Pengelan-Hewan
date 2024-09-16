using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelUnta : MonoBehaviour
{
    public GameObject Panel;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("unta"))
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
        }
    }
}
