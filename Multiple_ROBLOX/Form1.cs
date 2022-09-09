// Decompiled with JetBrains decompiler
// Type: Multiple_ROBLOX.Form1
// Assembly: Multiple ROBLOX, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2641F899-BEB0-4C0A-AFD2-905DAFD40D30
// Assembly location: C:\Users\14847\Downloads\Multiple_ROBLOX.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Multiple_ROBLOX
{
  public class Form1 : Form
  {
    private IContainer components;
    private Label label1;
    private Label label2;
    private LinkLabel linkLabel1;
    private Label label3;

    public Form1() => this.InitializeComponent();

    private void Form1_Load(object sender, EventArgs e)
    {
      Mutex mutex = new Mutex(true, "ROBLOX_singletonMutex");
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("discord.gg/9CBtbKWAVU");

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.label1 = new Label();
      this.label2 = new Label();
      this.linkLabel1 = new LinkLabel();
      this.label3 = new Label();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.BackColor = Color.Transparent;
      this.label1.Font = new Font("Verdana", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(11, 33);
      this.label1.Name = "label1";
      this.label1.Size = new Size(88, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "324A4A31";
      this.label2.AutoSize = true;
      this.label2.BackColor = Color.Transparent;
      this.label2.Font = new Font("Verdana", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.White;
      this.label2.Location = new Point(9, 8);
      this.label2.Name = "label2";
      this.label2.Size = new Size(261, 25);
      this.label2.TabIndex = 1;
      this.label2.Text = "";
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.BackColor = Color.Transparent;
      this.linkLabel1.Font = new Font("Verdana", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.linkLabel1.ForeColor = Color.White;
      this.linkLabel1.LinkColor = Color.White;
      this.linkLabel1.Location = new Point(82, 237);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new Size(118, 18);
      this.linkLabel1.TabIndex = 2;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = ".gg/9CBtbKWAVU";
      this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      this.label3.AutoSize = true;
      this.label3.BackColor = Color.Transparent;
      this.label3.Font = new Font("Verdana", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.White;
      this.label3.Location = new Point(5, 81);
      this.label3.Name = "label3";
      this.label3.Size = new Size(274, 126);
      this.label3.TabIndex = 3;
      this.label3.Text = componentResourceManager.GetString("label3.Text");
      this.label3.TextAlign = ContentAlignment.TopCenter;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackgroundImage = (Image) componentResourceManager.GetObject("$this.BackgroundImage");
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.ClientSize = new Size(284, 261);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.linkLabel1);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MaximumSize = new Size(300, 300);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(300, 300);
      this.Name = nameof (Form1);
      this.Text = "Multiple Roblox Windows.";
      this.Load += new EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
