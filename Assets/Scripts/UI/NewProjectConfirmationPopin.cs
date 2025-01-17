﻿using ErgoShop.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ErgoShop.UI
{
    /// <summary>
    ///     Confirmation popin to start a new project (reload software)
    /// </summary>
    public class NewProjectConfirmationPopin : MonoBehaviour
    {
        public bool goNew;

        // Start is called before the first frame update
        private void Start()
        {
            gameObject.SetActive(false);
        }

        // Update is called once per frame
        private void Update()
        {
        }

        private void Proceed()
        {
            if (goNew)
                SceneManager.LoadScene(0);
            else
                ProjectManager.Instance.LoadProjectForReal();
        }

        public void SaveAndChange()
        {
            if (ProjectManager.Instance.SaveProject()) Proceed();
        }

        public void ChangeWithoutSave()
        {
            Proceed();
        }

        public void CancelAction()
        {
            gameObject.SetActive(false);
        }
    }
}