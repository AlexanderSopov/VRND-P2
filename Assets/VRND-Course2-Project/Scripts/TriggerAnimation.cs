using UnityEngine;
using System.Collections;

public class TriggerAnimation : MonoBehaviour {
    public string AnimationName;
    public Animator stateMachine;
    private GvrViewer viewer;


    void Start() {
        // Locate the GvrViewer instance
        viewer = (GvrViewer)FindObjectOfType(typeof(GvrViewer));
        if (viewer == null)
        {
            Debug.LogError("No GvrViewer found. Please drag the GvrViewerMain prefab into the scene.");
            return;
        }
    }

    void Update() {
        viewer.UpdateState(); //need to update the data here otherwise we dont get mouse clicks; this is because we are automatically creating the GVRSDK (seems like a bug)
        if (viewer.Triggered)
        {
            Debug.LogError("whatevs");
            stateMachine.SetTrigger(AnimationName);
        }
        
    }

}