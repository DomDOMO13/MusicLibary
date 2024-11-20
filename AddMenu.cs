using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using musicplayer.Database;
using musicplayer.services;

namespace musicplayer
{
    public partial class AddMenu : Form
    {
        ILibraryService libservice;
        
        public AddMenu(ILibraryService service)
        {
            InitializeComponent();
            this.libservice = service;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.AddSong();
        }

        void AddSong() {
            var song = new Song();
            song.Title = this.nameTb.Text.Trim();
            song.Artist = this.artistTb.Text.Trim();
            song.Genre = this.genreTb.Text.Trim();
            this.libservice.AddSong(song);
        }
    }
}
