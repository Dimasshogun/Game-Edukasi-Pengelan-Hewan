using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelKangguru : MonoBehaviour
{
    public GameObject Panel;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("kangguru"))
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
        }
    }
}