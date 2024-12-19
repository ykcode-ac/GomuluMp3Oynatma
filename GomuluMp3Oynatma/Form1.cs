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

namespace GomuluMp3Oynatma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
            isPlaying = false;
        }

        private WindowsMediaPlayer player;
        private bool isPlaying;
        private double currentPosition = 0;  // Şarkının duraklatıldığı yer

        private void btnBaslaDur_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.Combine(Application.StartupPath, "muzik.mp3");

            if (isPlaying)
            {
                // Şarkıyı duraklat
                currentPosition = player.controls.currentPosition;  // Şarkının mevcut konumunu kaydet
                player.controls.pause();
                isPlaying = false;
                btnBaslaDur.Text = "Başlat";
            }
            else
            {
                // Şarkıyı başlat
                if (currentPosition > 0)  // Eğer duraklatıldığında bir konum kaydedildiyse
                {
                    player.controls.currentPosition = currentPosition;  // Kaldığı yerden devam et
                }
                else
                {
                    player.URL = filePath; // MP3 dosyasının tam yolu
                }

                player.controls.play();
                isPlaying = true;
                btnBaslaDur.Text = "Duraklat";
            }
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            // Şarkıyı durdur ve pozisyonu sıfırla
            player.controls.stop();
            player.controls.currentPosition = 0;  // Şarkıyı başa al
            currentPosition = 0;  // Durduktan sonra pozisyonu sıfırla
            isPlaying = false;
            btnBaslaDur.Text = "Başlat"; // Başlat butonuna dön
        }
    }
}
