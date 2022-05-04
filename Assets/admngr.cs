using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class admngr : MonoBehaviour {

    public string gameId = "4700101";
    public string placementId = "Banner_Android";
    public bool testMode = true;

    void Start () {
        // Initialize the SDK if you haven't already done so:
        Advertisement.Initialize (gameId, testMode);
        StartCoroutine (ShowBannerWhenReady ());
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
    }

    IEnumerator ShowBannerWhenReady () {
      yield return new WaitForSeconds(0.2f);
        Advertisement.Banner.Show (placementId);
    }
}