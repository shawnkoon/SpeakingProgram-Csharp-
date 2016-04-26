using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace speakingProgram
{
    public partial class Form1 : Form
    {
        private SpeechSynthesizer voice;
        public Form1()
        {
            InitializeComponent();
            this.inputBox.Text = "Hello, this is Shawnkoon's Speach Program!";
            voice = new SpeechSynthesizer();
        }

        private void speakButton_Click(object sender, EventArgs e)
        {
            int volume, rate;
            voice.SpeakAsyncCancelAll();

            volume = Int32.Parse(volumeBox.Text);
            rate = Int32.Parse(rateBox.Text);

            voice.Volume = volume;
            voice.Rate = rate;
            // voice.Voice = for fun;

            voice.Speak(inputBox.Text);

        }

        private void volumeBox_Leave(object sender, EventArgs e)
        {
            int volume = Int32.Parse(volumeBox.Text);

            if(volume < 0 || volume > 100)
            {
                MessageBox.Show("Please Type number 0 - 100");
                volumeBox.Text = "50";
                volumeBox.Focus();
            }
        }

        private void rateBox_Leave(object sender, EventArgs e)
        {
            int rate = Int32.Parse(rateBox.Text);

            if(rate < -10 || rate > 10)
            {
                MessageBox.Show("Please Type number -10 to 10");
                rateBox.Text = "0";
                rateBox.Focus();
            }
        }
    }
}
