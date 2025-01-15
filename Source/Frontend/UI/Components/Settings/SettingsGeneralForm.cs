using RTCV.NetCore;

namespace RTCV.UI
{
    using System;
    using System.Diagnostics;
    using System.Windows.Forms;
    using RTCV.CorruptCore;
    using RTCV.Common;
    using RTCV.UI.Modular;

    public partial class SettingsGeneralForm : ComponentForm, IBlockable
    {
        private new void HandleMouseDown(object s, MouseEventArgs e) => base.HandleMouseDown(s, e);
        private new void HandleFormClosing(object s, FormClosingEventArgs e) => base.HandleFormClosing(s, e);

        public SettingsGeneralForm()
        {
            InitializeComponent();

            PopoutAllowed = false;
        }

        //todo - rewrite this?
        /*
        private void btnImportKeyBindings_Click(object sender, EventArgs e)
        {

            if (VanguardImplementation.connector.netConn.status != NetworkStatus.CONNECTED)
            {
                MessageBox.Show("Can't import keybindings when not connected to Bizhawk!");
                return;
            }

            try
            {
                if (CorruptCore.CorruptCore.EmuDir.Contains(Path.DirectorySeparatorChar + "VERSIONS" + Path.DirectorySeparatorChar))
                {
                    var bizhawkFolder = new DirectoryInfo(CorruptCore.CorruptCore.EmuDir);
                    var LauncherVersFolder = bizhawkFolder.Parent.Parent;

                    var versions = LauncherVersFolder.GetDirectories().Reverse().ToArray();

                    var prevVersion = versions[1].Name;

                    var dr = MessageBox.Show(
                        "RTC Launcher detected,\n" +
                        $"Do you want to import Controller/Hotkey bindings from version {prevVersion}"
                        , $"Import config from previous version ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                        Stockpile.LoadBizhawkKeyBindsFromIni(versions[1].FullName + Path.DirectorySeparatorChar + "BizHawk\\config.ini");
                    else
                        Stockpile.LoadBizhawkKeyBindsFromIni();
                }
                else
                    Stockpile.LoadBizhawkKeyBindsFromIni();
            }
            finally
            {
            }
        }*/

        private void OpenOnlineWiki(object sender, EventArgs e)
        {
            Process.Start("https://corrupt.wiki/");
        }

        private void ChangeRTCColor(object sender, EventArgs e)
        {
            Colors.SelectRTCColor();
        }

        private void HandleDisableBizhawkOSDChange(object sender, EventArgs e)
        {
            Params.SetOrRemoveParam(RTCSPEC.CORE_EMULATOROSDDISABLED, cbDisableEmulatorOSD.Checked);
            RtcCore.EmulatorOsdDisabled = cbDisableEmulatorOSD.Checked;
        }

        private void HandleAllowCrossCoreCorruptionChange(object sender, EventArgs e)
        {
            Params.SetOrRemoveParam("ALLOW_CROSS_CORE_CORRUPTION", cbAllowCrossCoreCorruption.Checked);
            RtcCore.AllowCrossCoreCorruption = cbAllowCrossCoreCorruption.Checked;
        }

        private void HandleDontCleanAtQuitChange(object sender, EventArgs e)
        {
            Params.SetOrRemoveParam("DONT_CLEAN_SAVESTATES_AT_QUIT", cbDontCleanAtQuit.Checked);
            RtcCore.DontCleanSavestatesOnQuit = cbDontCleanAtQuit.Checked;
        }

        private void HandleUncapIntensityChange(object sender, EventArgs e)
        {
            Params.SetOrRemoveParam("UNCAP_INTENSITY", cbUncapIntensity.Checked);
            S.GET<GeneralParametersForm>().multiTB_Intensity.UncapNumericBox = cbUncapIntensity.Checked;
            S.GET<GlitchHarvesterIntensityForm>().multiTB_Intensity.UncapNumericBox = cbUncapIntensity.Checked;
        }

        private void HandleRasterizeUponStockpilingChange(object sender, EventArgs e)
        {
            Params.SetOrRemoveParam("RASTERIZE_VMD_UPON_STOCKPILING", cbRasterizeUponStockpiling.Checked);
        }

        private void RefreshInputDevices(object sender, EventArgs e)
        {
            Input.Input.Initialize();
        }

        private void btnWatchTutorialVideo_Click(object sender, EventArgs e)
        {
            Process.Start("http://rtctutorialvideo.r5x.cc/");
        }

        private void btnResetRandomSeed_Click(object sender, EventArgs e)
        {
            RtcCore.ResetSeed();
        }

        private void cbAutoUncorrupt_CheckedChanged(object sender, EventArgs e)
        {
            RtcCore.AutoUncorrupt = cbAutoUncorrupt.Checked;
        }
    }
}
