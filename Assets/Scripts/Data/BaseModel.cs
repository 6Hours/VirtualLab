using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Data.Property;

namespace Data.Model
{
    public abstract class BaseModel : MonoBehaviour
    {
        Dictionary<string, PropertyModel<object>> Properties = new Dictionary<string, PropertyModel<object>>();
        Tween modelProcess;

        public abstract void InitializeModel();
        public virtual void PlayModel(float playbackSpeed)
        {
            modelProcess.Kill();
            SetStartValues();
            modelProcess = DOTween.To(() => 0f, (v) => ModelCycleExecute(v), 1f, playbackSpeed);
        }
        public virtual PropertyModel<object> GetProperty(string propertyKey)
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
