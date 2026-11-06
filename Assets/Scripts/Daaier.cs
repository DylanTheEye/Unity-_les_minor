using UnityEngine;

public class Daaier : MonoBehaviour
{
    public float snelheid = 90f;

    public bool draaien = true;

    [SerializeField] private float hoogte = 1f;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hallo Unity");
    }

    // Update is called once per frame
    void Update()
    {

        Draai(snelheid);
       
    }

    void Draai(float tempo)
    {
        if (draaien)
        {
            float stap = tempo * Time.deltaTime;
            transform.Rotate(0, stap, 0);
        }

    }
}
