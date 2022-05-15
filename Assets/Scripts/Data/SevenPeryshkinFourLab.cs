using Data.Property;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Model
{
    public class SevenPeryshkinFourLab : BaseModel
    {
        float waterLevel;
        float heightPosition;
        int curObject;
        float[] objsVolume = { 240f, 360f, 200f };

        public override void InitializeModel()
        {
            Properties.Add("WaterLevel", new PropertyFloat(0, 300));
            Properties.Add("objectHeightPosition", new PropertyFloat(0f, 0.7f));
            Properties.Add("CurrentObject", new PropertyInt(0, 2));

            Properties["WaterLevel"].Value = 0f;
            Properties["objectHeightPosition"].Value = 0.7f;
            Properties["CurrentObject"].Value = 0;

            SetStartValues();
        }

        protected override void ModelCycleExecute(float progress)
        {
            Properties["WaterLevel"].Value = waterLevel + Mathf.Min(objsVolume[curObject], waterLevel) * progress;
            Properties["objectHeightPosition"].Value = heightPosition - heightPosition * progress;
        }

        protected override void SetStartValues()
        {
            waterLevel = (float)Properties["WaterLevel"].Value;
        }

        public override void Stop()
        {
            base.Stop();
            Properties["WaterLevel"].Value = waterLevel;
            Properties["objectHeightPosition"].Value = heightPosition;
        }
    }
}
