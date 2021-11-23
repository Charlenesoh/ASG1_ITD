using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dictionary : MonoBehaviour
{
    private Dictionary<GameObject, bool> trackedObjectStatus = new Dictionary<GameObject, bool>();

    public Text displayText;

    public void ObjectTracked(GameObject objectToTrack)
    {
        if (objectToTrack != null)
        {
            trackedObjectStatus[objectToTrack] = true;
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
            displayText.text = "";

            foreach (KeyValuePair<GameObject, bool> objectStatus in trackedObjectStatus)
            {
                displayText.text += objectStatus.Key.name + ": " + objectStatus.Value + '\n';
            }
        }
    }
}
