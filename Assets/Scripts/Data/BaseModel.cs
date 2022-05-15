using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Data.Property;

namespace Data.Model
{
    public abstract class BaseModel : MonoBehaviour
    {
        protected Dictionary<string, PropertyModel> Properties = new Dictionary<string, PropertyModel>();
        protected Tween modelProcess;

        public abstract void InitializeModel();
        public virtual void PlayModel(float playbackSpeed)
        {
            modelProcess.Kill();
            SetStartValues();
            modelProcess = DOTween.To(() => 0f, (v) => ModelCycleExecute(v), 1f, playbackSpeed);
        }
        public virtual PropertyModel GetProperty(string propertyKey)
        {
            return Properties[propertyKey];
        }
        protected abstract void SetStartValues();
        protected abstract void ModelCycleExecute(float progress);

        public virtual void Stop()
        {
            modelProcess.Kill();
        }
    }
}
