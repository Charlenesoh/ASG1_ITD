using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dictionary : MonoBehaviour
{
    private Dictionary<GameObject, bool> trackedObjectStatus = new Dictionary<GameObject, bool>();

    public Text displayText;
    bool pog;

    private void Update()
    {
        UpdateObjectStatus();
    }

    public void ObjectTracked(GameObject objectToTrack)
    {
        if (objectToTrack != null)
        {
            trackedObjectStatus[objectToTrack] = true;
            displayText.text = "";
        }
        else
        {
            return;
        }
    }

    public void ObjectLost(GameObject objectToTrack)
    {
        if (objectToTrack != null)
        {
            trackedObjectStatus[objectToTrack] = false;
            displayText.text = "finding object";
        }
        else
        {
            return;
        }
    }

    void UpdateObjectStatus()
    {
        if (trackedObjectStatus.Count > 0)
        {
            foreach (KeyValuePair<GameObject, bool> objectStatus in trackedObjectStatus)
            {
                displayText.text += objectStatus.Key.name;
            }
        }
    }
}
