using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using musicplayer.services;

namespace musicplayer
{
    public partial class Search : Form
    {
        ILibraryService libraryService;

        public Search(ILibraryService libraryService)
        {
            InitializeComponent();
            this.libraryService = libraryService;

           this.searchBtn.Click += OnClick;
        }

        private void OnClick(object? sender, EventArgs e)
        {
            this.searchFunction();
        }

        void searchFunction() {
            var keyterm = this.nameTb.Text.Trim();
            var songs = this.libraryService.SearchByTitle(keyterm);

            MessageBox.Show(" Found" + songs.Count);
        }
    }
}
