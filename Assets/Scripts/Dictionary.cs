using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dictionary : MonoBehaviour
{
    private Dictionary<GameObject, bool> trackedObjectStatus = new Dictionary<GameObject, bool>();

    public Text displayText;

    // run update object tracked name onto text 
    private void Update()
    {
        UpdateObjectStatus();
    }

    // track object tag 
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

    // when object is not seen on screen / tracked on screen
    public void ObjectLost(GameObject objectToTrack)
    {
        if (objectToTrack != null)
        {
            trackedObjectStatus[objectToTrack] = false;
            displayText.text = "";
        }
        else
        {
            return;
        }
    }

    // update status
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
