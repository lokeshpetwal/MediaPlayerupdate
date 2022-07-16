using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "Node0")
            {
                richTextBox1.Text = "Media player software is a type of application software for playing multimedia computer files like audio and video files. Media players commonly display standard media control icons known from physical devices such as tape recorders and CD players, such as play ( ▶️ ), pause ( ⏸ ), fastforward (⏩️), backforward (⏪), and stop ( ⏹️ ) buttons. In addition, they generally have progress bars (or playback bars), which are sliders to locate the current position in the duration of the media file.";

            }

            if (e.Node.Name == "Node1")
            {
                richTextBox1.Text = "These are common icons on physical devices and media player software. They are commonly found on portable media players, VCRs, DVD players, record players, remote controls, tape players and multimedia keyboards. Their application is described in ISO/IEC 180  The main symbols date back to the 1960s, with the Pause symbol having reportedly been invented at Ampex during that decade for use on reel - to - reel audio recorder controls, due to the difficulty of translating the word pause into some languages used in foreign markets.The Pause symbol was designed as a combination of the existing square Stop symbol and the caesura, and was intended to evoke the concept of an interruption or stutter stop.[2][3]";
            }


            if (e.Node.Name == "Node2")
            {

                richTextBox1.Text = "Different media players have different goals and feature sets. Video players are a group of media players that have their features geared more towards playing digital video. For example, Windows DVD Player exclusively plays DVD-Video discs and nothing else. Media Player Classic can play individual audio and video files but many of its features such as color correction, picture sharpening, zooming, set of hotkeys, DVB support and subtitle support are only useful for video material such as films and cartoons. Audio players, on the other hand, specialize in digital audio. For example, AIMP exclusively plays audio formats. MediaMonkey can play both audio and video formats, but many of its features including media library, lyric discovery, music visualization, online radio, audiobook indexing, and tag editing are geared toward consumption of audio material; watching video files on it can be a trying feat. General-purpose media players also do exist. For example, Windows Media Player has exclusive features for both audio and video material, although it cannot match the feature set of Media Player Classic and MediaMonkey combined.";

            }
            if (e.Node.Name == "Node3")
            {
                richTextBox1.Text = "You will want to provide the user with buttons to control the selection and playback of media items. Using the appropriate buttons, you can play, pause, or stop the media item, move to different items in the playlist, mute the sound, or provide information about the media item that is playing.You do not need to provide all button functions in your skin, but the best user experience will probably include at least the PlayPause, Stop, or PlayPauseStop, Prev, and Next button functions The following button functions are available:Play , pause , stop , resume, next , previous ,etc....";

            }
            if (e.Node.Name == "Node5")
            {
                richTextBox1.Text = "http://google.com";

            }

            }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close() ;
        }
    }
}
    
