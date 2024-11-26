namespace RTCV.UI
{
    using System;
    using System.Windows.Forms;
    using RTCV.Common;
    using RTCV.CorruptCore;
    using RTCV.NetCore;
    using RTCV.UI.Modular;

    public partial class GeneralParametersForm : ComponentForm, IBlockable
    {
        private new void HandleMouseDown(object s, MouseEventArgs e) => base.HandleMouseDown(s, e);
        private new void HandleFormClosing(object s, FormClosingEventArgs e) => base.HandleFormClosing(s, e);

        public GeneralParametersForm()
        {
            InitializeComponent();
            multiTB_Intensity.ValueChanged += (sender, args) => RtcCore.Intensity = multiTB_Intensity.Value;
            multiTB_Intensity.registerSlave(S.GET<GlitchHarvesterIntensityForm>().multiTB_Intensity);

            multiTB_ErrorDelay.ValueChanged += (sender, args) => RtcCore.ErrorDelay = multiTB_ErrorDelay.Value;

            var ceForm = S.GET<CorruptionEngineForm>();
            btnClearAllFreezes.Click += ceForm.ClearCheats;
            cbClearFreezesOnRewind.CheckedChanged += ceForm.OnClearRewindToggle;
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            cbBlastRadius.SelectedIndex = 0;
        }

        private void OnBlastRadiusSelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enum.TryParse(cbBlastRadius.SelectedItem.ToString(), out BlastRadius radius))
            {
                RtcCore.Radius = radius;
            }
        }

        private void UpdateCreateInfiniteUnits(object sender, EventArgs e)
        {
            RtcCore.CreateInfiniteUnits = cbCreateInfiniteUnits.Checked;
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            object paramValue = AllSpec.VanguardSpec[VSPEC.OVERRIDE_DEFAULTMAXINTENSITY];

            if (paramValue is int maxIntensity)
            {
                multiTB_Intensity.SetMaximum(maxIntensity, false);
            }
        }
    }
}
