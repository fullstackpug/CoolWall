﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolWall.Component
{
    public partial class ImageViewer : Form
    {
        public ImageViewer(Image image)
        {
            InitializeComponent();
            this.pictureBox1.Image = image;
        }
    }
}
