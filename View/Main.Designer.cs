namespace QLNhaHang.View
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolTip = new ToolTip(components);
            menuStrip1 = new MenuStrip();
            MenuToolStrip = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            bànĂnToolStripMenuItem = new ToolStripMenuItem();
            caLàmToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuToolStrip, hóaĐơnToolStripMenuItem, nhânViênToolStripMenuItem, bànĂnToolStripMenuItem, caLàmToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(843, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuToolStrip
            // 
            MenuToolStrip.Name = "MenuToolStrip";
            MenuToolStrip.Size = new Size(73, 24);
            MenuToolStrip.Text = "Món ăn";
            MenuToolStrip.Click += mónĂnToolStripMenuItem_Click;
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Size = new Size(81, 24);
            hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            hóaĐơnToolStripMenuItem.Click += hóaĐơnToolStripMenuItem_Click;
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(89, 24);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;
            // 
            // bànĂnToolStripMenuItem
            // 
            bànĂnToolStripMenuItem.Name = "bànĂnToolStripMenuItem";
            bànĂnToolStripMenuItem.Size = new Size(68, 24);
            bànĂnToolStripMenuItem.Text = "Bàn ăn";
            bànĂnToolStripMenuItem.Click += bànĂnToolStripMenuItem_Click;
            // 
            // caLàmToolStripMenuItem
            // 
            caLàmToolStripMenuItem.Name = "caLàmToolStripMenuItem";
            caLàmToolStripMenuItem.Size = new Size(69, 24);
            caLàmToolStripMenuItem.Text = "Ca làm";
            caLàmToolStripMenuItem.Click += caLàmToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 675);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(843, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 697);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Main";
            Text = "Main";
            Click += Main_Click;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem MenuToolStrip;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem bànĂnToolStripMenuItem;
        private ToolStripMenuItem caLàmToolStripMenuItem;
    }
}



