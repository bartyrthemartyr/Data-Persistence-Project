using TMPro;
using UnityEngine;

public class NameField : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TMP_InputField input = gameObject.GetComponent<TMP_InputField>();
        input.onEndEdit.AddListener(SetName);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetName(string name)
    {
        if (ScoreManager.Instance != null && !string.IsNullOrEmpty(name))
        {
            ScoreManager.Instance.currentName = name;
        }
    }
}
