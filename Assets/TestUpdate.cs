using UnityEngine;

public class TestUpdate : MonoBehaviour
{
    void Awake()
    {
        Debug.Log(name + "Awake");
    }

    void OnEnable()
    {
        Debug.Log(name + "OnEnable");
    }

    void OnDisable()
    {
        Debug.Log(name + "OnDisable");
    }

	void Start()
    {
        Debug.Log(name + "Start");
	}

	void Update()
    {
        Debug.Log(name + "Update");
    }

    void LateUpdate()
    {
        Debug.Log(name + "LateUpdate");
    }

    void FixedUpdate()
    {
        Debug.Log(name + "FixedUpdate");
    }
}
