using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectionTrigger : MonoBehaviour
{
    Renderer rend;
    Material material;

    Material m_material;


    [SerializeField] GameObject plancha_resultado;
    private void Start(){
        rend = GetComponent<Renderer>();
        material = rend.material;
        m_material = plancha_resultado.GetComponent<Renderer>().material = material;

    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other){
        Debug.Log("T. Enter" + other.gameObject.name);
        plancha_resultado.GetComponent<Renderer>().material = material;
    }

    private void OnTriggerStay(Collider other){
        Debug.Log("T. Stay" + other.gameObject.name);
        plancha_resultado.GetComponent<Renderer>().material = material;
    }

    private void OnTriggerExit(Collider other){
        Debug.Log("T. Exit" + other.gameObject.name);
        plancha_resultado.GetComponent<Renderer>().material = m_material;
    }
}
