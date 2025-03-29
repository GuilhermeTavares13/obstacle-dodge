using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float yValue = 0f; // SerializeField significa que posso alterar os valores do objeto na Unity
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(xValue, yValue, zValue);
    }
}
