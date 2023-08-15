using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement;

namespace Joshua.SceneManager
{
    /// <summary>
    /// 場景管理器：載入場景和退出遊戲。
    /// </summary>
    public class SceneManager : MonoBehaviour
    {
        [Header("Sounds Info")]
        [SerializeField, Range(0.1f, 3)]
        private float soundDuration = 2.2f;

        private string sceneNameToChange;

        /// <summary>
        /// 透過字串切換場景
        /// </summary>
        /// <param name="_sceneName"></param>
        public void ChangeScene(string _sceneName)
        {
            Invoke("DelayChangeScene", soundDuration);
            sceneNameToChange = _sceneName;
        }

        private void DelayChangeScene()
        {

            UnitySceneManager.SceneManager.LoadScene(sceneNameToChange);
        }

        /// <summary>
        /// 退出遊戲
        /// </summary>
        public void Quit()
        {
            Invoke("DelayQuit", soundDuration);
        }

        private void DelayQuit()
        {
            Application.Quit();
        }
    }
}
