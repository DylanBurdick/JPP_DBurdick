using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0,6,-9);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame (AFTER the update function is called)
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
