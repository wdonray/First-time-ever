using UnityEngine;
using System.Collections;

public class Donray : MonoBehaviour
{

    // Use this for initialization
    public string m_name;
    public bool m_isPlayer;
    public bool m_isHorse;
    void Awake()
    {
        Debug.Log("awake has been called");
    }
    void Start()
    {
        Debug.Log(m_name);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up);
            Debug.Log(m_name + " jump ");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward);
            Debug.Log(m_name + " forward ");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back);
            Debug.Log(m_name + " back ");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right);
            Debug.Log(m_name + " right ");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left);
            Debug.Log(m_name + " left ");
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, 10);
            Debug.Log(m_name + " sprint forward ");
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(0, -2, 0);
            Debug.Log(m_name + " sprint right ");
        }
    }
}
