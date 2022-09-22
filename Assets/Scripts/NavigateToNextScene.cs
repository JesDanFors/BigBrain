using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigateToNextScene : MonoBehaviour{
  public string nextScene;
  public void NextScene(){
    SceneManager.LoadScene(nextScene);
  }
}
