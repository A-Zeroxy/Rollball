using UnityEngine;

public class controlercamra : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - player.transform.position;  
    }

    // Update is called once per fram
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;  
    }
}
