﻿namespace rpg
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.stage = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stage)).BeginInit();
            this.SuspendLayout();
            // 
            // stage
            // 
            this.stage.Location = new System.Drawing.Point(0, 0);
            this.stage.Name = "stage";
            this.stage.Size = new System.Drawing.Size(793, 600);
            this.stage.TabIndex = 1;
            this.stage.TabStop = false;
            this.stage.MouseLeave += new System.EventHandler(this.stage_MouseLeave);
            this.stage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.stage_MouseMove);
            this.stage.Click += new System.EventHandler(this.stage_Click);
            this.stage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stage_MouseClick);
            this.stage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stage_MouseDown);
            this.stage.MouseEnter += new System.EventHandler(this.stage_MouseEnter);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 600);
            this.Controls.Add(this.stage);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.stage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox stage;
        private System.Windows.Forms.Timer timer1;
    }
}

