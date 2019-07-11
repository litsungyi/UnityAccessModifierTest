using UnityEditor;
using UnityEngine;

public class TestUpdateRoot : MonoBehaviour
{
    [SerializeField] private GameObject object1;
    [SerializeField] private GameObject object2;
    [SerializeField] private int speedValue = 1;
    private bool enableChange = false;

    private int fixedUpdateCount = 0;
    private int updateCount = 0;

    private void OnGUI()
    {
        var object1Visible = EditorGUILayout.Toggle("Object1", object1.activeSelf);
        if(object1Visible != object1.activeSelf)
        {
            object1.SetActive(object1Visible);
        }

        var object2Visible = EditorGUILayout.Toggle("Object2", object2.activeSelf);
        if (object2Visible != object2.activeSelf)
        {
            object2.SetActive(object2Visible);
        }
    }

    private void FixedUpdate()
    {
        ++fixedUpdateCount;
        Debug.Log("FixedUpdate: " + Time.fixedDeltaTime + "(" + fixedUpdateCount + "/" + updateCount + ")");
        updateCount = 0;
    }

    private void Update()
    {
        ++updateCount;
        Debug.Log("Update: " + Time.deltaTime + "(" + fixedUpdateCount + "/" + updateCount + ") " + enableChange);
        fixedUpdateCount = 0;

        if(!enableChange)
        {
            Debug.Log("Skip");
            enableChange = true;
            return;
        }

        int x = 0;
        var max = speedValue * 10000000;
        for (int i = 0; i < max; i++)
        {
            ++x;
        }

        enableChange = false;
    }
}
