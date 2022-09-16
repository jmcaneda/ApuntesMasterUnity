using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ActivateObject : MonoBehaviour
{
    public GameObject cubo;
    public GameObject esfera;
    public TapController tapController;
   
    private void Update()
    {
        if (tapController.isDoubleTouch)
        {
            RaycastHit hit;
            if (Physics.Raycast(tapController.ray, out hit))
            {
                if (hit.transform.tag == "cube")
                {
                    cubo.SetActive(false);
                    esfera.SetActive(true);
                }
                if (hit.transform.tag == "esfera")
                {
                    cubo.SetActive(true);
                    esfera.SetActive(false);
                }
            }
            tapController.isDoubleTouch = false;

        } else if (tapController.isSingleTouch)
        {
            RaycastHit hit;
            if (Physics.Raycast(tapController.ray, out hit))
            {
                if (hit.transform.tag == "cube")
                {
                    cubo.GetComponent<MeshRenderer>().material.color = Color.red;
                    esfera.GetComponent<MeshRenderer>().material.color = Color.white;
                }
                if (hit.transform.tag == "esfera")
                {
                    esfera.GetComponent<MeshRenderer>().material.color = Color.red;
                    cubo.GetComponent<MeshRenderer>().material.color = Color.white;
                }
            }
            tapController.isSingleTouch = false;
        }
        
    }
}