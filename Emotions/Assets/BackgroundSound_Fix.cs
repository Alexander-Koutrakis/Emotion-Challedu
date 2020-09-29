using UnityEngine;

public class BackgroundSound_Fix : MonoBehaviour
{
    public AudioClip clip;
    // Start is called before the first frame update
    void OnEnable()
    {
        Debug.Log("Enabled");
        BackGround_Audio_Manager.Instance.AddBackgroundClip(clip);
    }

}
