using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double time;
       
       
 
       private void play_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = textBox1.Text;
            axWindowsMediaPlayer2.Ctlcontrols.play();
            timer1.Start();
            
        }  
        
        private void resume_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer2.Ctlcontrols.currentPosition = time;
            this.axWindowsMediaPlayer2.Ctlcontrols.play();
            timer1.Start();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.pause();
            time =this.axWindowsMediaPlayer2.Ctlcontrols.currentPosition;
            timer1.Stop();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.stop();
        }
        string[] paths, files;
        private void choose_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for(int x = 0; x < files.Length; x++)
                {
                    PlayList.Items.Add(files[x]);
                }
                this.textBox1.Text=ofd.FileName;
            }
            PlayList.Visible = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.settings.volume = trackBar1.Value;
            volumelabel.Text = trackBar1.Value.ToString();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void mediaPlayer_Enter(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer2.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)axWindowsMediaPlayer2.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)axWindowsMediaPlayer2.Ctlcontrols.currentPosition;
            }
            progresslabel.Text = axWindowsMediaPlayer2.Ctlcontrols.currentPositionString;
            progresslabel2.Text = axWindowsMediaPlayer2.Ctlcontrols.currentItem.durationString.ToString();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //if (axWindowsMediaPlayer1.currentMedia.duration != 0)
            //{
            //    double newper = Convert.ToDouble((progressBar1.Value) / 100);
            //    int durationVar = Convert.ToInt32(axWindowsMediaPlayer1.currentMedia.duration * 1000);
            //    int pos = Convert.ToInt32((durationVar * newper) / 1000);

            //}
            //else
            //    progressBar1.Value = 0;
            //if (mediaPlayer.playState == WMPPlayState.wmppsReady)
            //{
            //    progressBar1.Maximum = (int)mediaPlayer.Ctlcontrols.currentItem.duration;
            //    progressBar1.Value = (int)mediaPlayer.Ctlcontrols.currentPosition;
            //}
            //progresslabel.Text = mediaPlayer.Ctlcontrols.currentPositionString;
            //progresslabel2.Text = mediaPlayer.Ctlcontrols.currentItem.durationString.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (PlayList.SelectedIndex < PlayList.Items.Count - 1)
            {
                PlayList.SelectedIndex = PlayList.SelectedIndex + 1; 
            }

        }

        private void mediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)

        {
                //if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                //{
                //    progressBar1.Maximum = (intaxWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                //    progressBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                //}
                //progresslabel.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                //progresslabel2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString.ToString();
        }

      

        private void fastforword_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.fastForward();
            
        }

        private void fastreverse_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.fastReverse();
        }

        private void playBackToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void AxWindowsMediaPlayer1(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            axWindowsMediaPlayer2.URL = openFileDialog1.FileName;
            
               timer1.Start();
        }

      

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            play.PerformClick();
           
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pause.PerformClick();
        }

        private void forwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastforword.PerformClick();
        }

        private void reverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastreverse.PerformClick(); 
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stop.PerformClick();
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            next.PerformClick();
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            previous.PerformClick();
        }

        private void playListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void PlayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = paths[PlayList.SelectedIndex];
            axWindowsMediaPlayer2.Ctlcontrols.play();
            timer1.Start();
        }

        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer2.playState == WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer2.fullScreen = true;
            }

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void progresslabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {

        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (PlayList.SelectedIndex > 0)
            {
                PlayList.SelectedIndex= PlayList.SelectedIndex - 1;
            }
        }
    }
}
